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

        #endregion

        #region Default constructor

        public SQLCommander()
            : base(ConnectString)
        { }

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
        /// Model→SQLParameter変換
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private SqlParameter[] ToSqlParameters<TModel>(TModel model)
           where TModel : class
        {
            if (model == null) { throw new NullReferenceException(); }

            var parameters = typeof(TModel).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                           .Select(x => new SqlParameter(string.Format("@{0}", x.Name), this.ToDBNull(x.GetValue(model, null)))
                                                                         { Direction = ParameterDirection.Input } )
                                           .ToArray();
            return parameters;
        }

        /// <summary>
        /// テーブル型パラメータ変換
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        private SqlParameter ToTableParameter<TModel>(List<TModel> models)
            where TModel : class
        {
            if (models == null) { throw new NullReferenceException(); }

            var properties = typeof(TModel).GetProperties().ToList();
            var table = new DataTable();

            //↓↓↓FixMe:Need refactoring↓↓↓
            //列生成
            //リフレクションが派生クラス→基底クラスというアクセス手順を踏むため、基底クラスのプロパティから取得する
            var baseType = typeof(TModel).BaseType.GetProperties().ToList();
            baseType.ForEach(x => table.Columns.Add(x.Name, x.PropertyType));

            foreach (var p in properties)
            {
                foreach (var q in baseType)
                {
                    if (p.Name != q.Name)
                    {
                        table.Columns.Add(p.Name, p.PropertyType);
                    }
                }
            }

            //行データ挿入
            foreach (var m in models)
            {
                var row = table.NewRow();

                for (int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = this.ToDBNull(properties.Where(x => x.Name == table.Columns[i].Caption).First().GetValue(m, null));
                }

                table.Rows.Add(row);
            }

            //↑↑↑Fix Me↑↑↑

            var param = new SqlParameter()
            {
                ParameterName = string.Format("@{0}s", typeof(TModel).Name),
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Structured,
                Value = table
            };

            return param;
        }

        #endregion

        #region Execute command

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql">SQL文 or ストアドコール</param>
        /// <returns>影響行数</returns>
        public int Execute(string sql)
        {
            try
            {
                return base.Database.ExecuteSqlCommand(sql);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql">SQL文 or ストアドコール</param>
        /// <param name="model"></param>
        /// <returns>影響行数</returns>
        public int Execute<TModel>(string sql, TModel model)
            where TModel : class
        {
            try
            {
                var args = this.ToSqlParameters(model);

                return base.Database.ExecuteSqlCommand(sql, args);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="models"></param>
        /// <returns>影響行数</returns>
        public int Execute<TModel>(string sql, List<TModel> models)
            where TModel : class
        {
            try
            {
                var arg = this.ToTableParameter(models);

                return base.Database.ExecuteSqlCommand(sql, arg);

            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コマンド実行
        /// </summary>
        /// <param name="sql">SQL文 or ストアド・プロシージャコール</param>
        /// <param name="model">DBへ渡すモデル</param>
        /// <param name="models">DBへ渡すリストモデル</param>
        /// <returns></returns>
        public int Execute<TModel, TList>(string sql, TModel model, List<TList> models)
            where TModel : class
            where TList : class
        {
            try
            {
                var args = this.ToSqlParameters(model);
                var table = this.ToTableParameter(models);

                var p = new List<SqlParameter>();
                p.Add(table);
                p.AddRange(args);

                return base.Database.ExecuteSqlCommand(sql, p);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// スカラー値取得
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>スカラー値</returns>
        public TResult ExecuteScalor<TResult>(string sql)
        {
            try
            {
                return base.Database.SqlQuery<TResult>(sql).Single();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// スカラー値取得
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>スカラー値</returns>
        public TResult ExecuteScalor<TResult, TModel>(string sql, TModel model)
            where TModel :class
        {
            try
            {
                var param = this.ToSqlParameters(model);
                return base.Database.SqlQuery<TResult>(sql, param).Single();
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Read data

        /// <summary>
        /// １件のデータを取得します
        /// </summary>
        /// <typeparam name="TResult">戻り値の型情報(クラス)</typeparam>
        /// <param name="sql">SQL文</param>
        /// <returns>取得データ</returns>
        public TResult Find<TResult>(string sql)
            where TResult : class
        {
            List<TResult> model = null;

            try
            {
                model = this.FindAll<TResult>(sql);
            }
            catch
            {
                throw;
            }

            return model.Count < 1 ? null : model.First();
        }

        /// <summary>
        /// 条件に合致する１件のデータを取得します
        /// </summary>
        /// <typeparam name="TResult">戻り値の型情報(クラス)</typeparam>
        /// <typeparam name="TCondition">検索条件の型情報(クラス)</typeparam>
        /// <param name="sql">SQL文</param>
        /// <param name="condition">検索条件モデル</param>
        /// <returns>取得データ</returns>
        public TResult Find<TResult, TCondition>(string sql, TCondition condition)
            where TResult : class
            where TCondition : class
        {
            List<TResult> model = null;

            try
            {
                model = this.FindBy<TResult, TCondition>(sql, condition);
            }
            catch
            {
                throw;
            }

            return model.Count < 1 ? null : model.First();
        }

        /// <summary>
        /// 全てのデータを取得します
        /// </summary>
        /// <typeparam name="TResult">戻り値の型情報(クラス)</typeparam>
        /// <param name="sql">SQL文</param>
        /// <returns>取得データ</returns>
        public List<TResult> FindAll<TResult>(string sql)
            where TResult : class
        {
            try
            {
                return base.Database.SqlQuery<TResult>(sql).ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 条件に合致するデータを取得します
        /// </summary>
        /// <typeparam name="TResult">戻り値の型情報(クラス)</typeparam>
        /// <typeparam name="TCondition">検索条件の型情報(クラス)</typeparam>
        /// <param name="sql">SQL文</param>
        /// <param name="condition">検索条件モデル</param>
        /// <returns>取得データ</returns>
        public List<TResult> FindBy<TResult, TCondition>(string sql, TCondition condition)
            where TResult : class
            where TCondition : class
        {
            var args = this.ToSqlParameters(condition);

            try
            {
                return this.Database.SqlQuery<TResult>(sql, args).ToList();
            }
            catch
            {
                throw;
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