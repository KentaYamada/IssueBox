using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace IssueBox.Models.Infrastructure
{
    /// <summary>
    /// DBアクセス
    /// </summary>
    public class SQLCommander : DbContext
    {
        #region Fields

        private static readonly string ConnectString = ConfigurationManager.ConnectionStrings["IssueBox"].ConnectionString;

        private DbContextTransaction _currentTransaction = null;

        private List<SqlParameter> _params = null;

        private SqlParameter[] GetSqlParams { get { return this._params.ToArray(); } }

        #endregion

        #region Default constructor

        public SQLCommander()
            : base(ConnectString)
        {
            this._params = new List<SqlParameter>();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// DBNull変換
        /// </summary>
        /// <param name="value">変換対象の値</param>
        /// <returns>value = Null:DBNull else:変換なし</returns>
        private object ToDBNull(object value)
        {
            return string.IsNullOrEmpty(Convert.ToString(value)) ? DBNull.Value : value;
        }

        /// <summary>
        /// SQLParameter変換
        /// </summary>
        /// <param name="model"></param>
        private void ToSqlParameters<TModel>(TModel model)
           where TModel : class
        {
            if (model == null) { throw new NullReferenceException(); }

            var target = typeof(TModel).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                       .ToList()
                                       .Select(p => new SqlParameter()
                                       {
                                           Direction = ParameterDirection.Input,
                                           ParameterName = string.Format("@{0}", p.Name),
                                           Value = this.ToDBNull(p.GetValue(model, null))
                                       })
                                       .ToArray();

            this._params.AddRange(target);
        }

        /// <summary>
        /// テーブル型パラメータ変換
        /// </summary>
        /// <param name="models"></param>
        private void ToTableParameter<TModel>(List<TModel> models)
            where TModel : class
        {
            if (models == null) { throw new NullReferenceException(); }
            
            var table = new DataTable();

            //列生成
            //リフレクションは派生クラス→基底クラスの順番でプロパティを読み込むので、
            //基底クラス→派生クラスの順番で列を生成するよう実装
            var list = new List<PropertyInfo>();
            var props = typeof(TModel).BaseType.GetProperties().ToList();
            
            list.AddRange(props);
            props.ForEach(v => list.AddRange(typeof(TModel).GetProperties().ToList().FindAll(x => x.Name != v.Name)));
            //list.ForEach(x => table.Columns.Add(x.Name, x.PropertyType));
            list.ForEach(x => table.Columns.Add(x.Name));

            //行データ挿入
            foreach (var m in models)
            {
                var row = table.NewRow();
                list.ForEach(x => row[x.Name] = this.ToDBNull(x.GetValue(m, null)));
                table.Rows.Add(row);
            }

            var param = new SqlParameter()
            {
                ParameterName = string.Format("@{0}s", typeof(TModel).Name),
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Structured,
                TypeName = string.Format("{0}S_T", typeof(TModel).Name.ToUpper()),
                Value = table
            };

            this._params.Add(param);
        }

        #endregion

        #region Execute command

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>影響行数</returns>
        public int Execute(string sql)
        {
            return base.Database.ExecuteSqlCommand(sql);
        }

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>影響行数</returns>
        public int Execute<TModel>(string sql, TModel model)
            where TModel : class
        {
            this.ToSqlParameters(model);

            try
            {
                return base.Database.ExecuteSqlCommand(sql, this.GetSqlParams);
            }
            finally
            {
                this._params.Clear();
            }
        }

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>影響行数</returns>
        public int Execute<TModel, TList>(string sql, TModel model, List<TList> models)
            where TModel : class
            where TList : class
        {
            this.ToSqlParameters(model);
            this.ToTableParameter(models);

            try
            {
                return base.Database.ExecuteSqlCommand(sql, this.GetSqlParams);
            }
            finally
            {
                this._params.Clear();
            }
        }

        #endregion

        #region Read data

        /// <summary>
        /// 全てのデータを取得します
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>取得データ</returns>
        public List<TResult> ReadAll<TResult>(string sql)
            where TResult : class
        {
            return base.Database.SqlQuery<TResult>(sql).ToList();
        }

        /// <summary>
        /// 条件に合致するデータを取得します
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <param name="condition">検索条件</param>
        /// <returns>取得データ</returns>
        public List<TResult> ReadAny<TResult, TCondition>(string sql, TCondition condition)
            where TResult : class
            where TCondition : class
        {
            this.ToSqlParameters(condition);

            try
            {
                return this.Database.SqlQuery<TResult>(sql, this.GetSqlParams).ToList();
            }
            finally
            {
                this._params.Clear();
            }
        }

        /// <summary>
        /// １件のデータを取得します
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>取得データ</returns>
        public TResult ReadOne<TResult>(string sql)
            where TResult : class
        {
            return base.Database.SqlQuery<TResult>(sql).FirstOrDefault();
        }

        /// <summary>
        /// 条件に合致する１件のデータを取得します
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <param name="condition">検索条件</param>
        /// <returns>取得データ</returns>
        public TResult ReadOne<TResult, TCondition>(string sql, TCondition condition)
            where TResult : class
            where TCondition : class
        {
            this.ToSqlParameters(condition);

            try
            {
                return base.Database.SqlQuery<TResult>(sql, this.GetSqlParams).FirstOrDefault();
            }
            finally
            {
                this._params.Clear();
            }
        }

        /// <summary>
        /// 単一値取得
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>単一値</returns>
        public TResult ReadScalor<TResult>(string sql)
        {
            return base.Database.SqlQuery<TResult>(sql).SingleOrDefault();
        }

        /// <summary>
        /// 単一値取得
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <returns>単一値</returns>
        public TResult ReadScalor<TResult, TCondition>(string sql, TCondition condition)
            where TCondition : class
        {
            this.ToSqlParameters(condition);

            try
            {
                return base.Database.SqlQuery<TResult>(sql, this.GetSqlParams).SingleOrDefault();
            }
            finally
            {
                this._params.Clear();
            }
        }

        #endregion

        #region Transaction control

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTransaction()
        {
            this._currentTransaction = base.Database.BeginTransaction();
        }

        /// <summary>
        /// コミット
        /// </summary>
        public void Commit()
        {
            if (this._currentTransaction != null)
            {
                this._currentTransaction.Commit();
                this._currentTransaction.Dispose();
                this._currentTransaction = null;
            }
        }

        /// <summary>
        /// ロールバック
        /// </summary>
        public void Rollback()
        {
            if (this._currentTransaction != null)
            {
                this._currentTransaction.Rollback();
                this._currentTransaction.Dispose();
                this._currentTransaction = null;
            }
        }

        #endregion
    }
}