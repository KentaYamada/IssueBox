using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    /// <summary>
    /// 製品モデルクラス
    /// </summary>
    public class TestProduct
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestProduct()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO PRODUCTS VALUES ('工房 DBKit', '1.0.0.0', 'TRUE', GETDATE())
                                                      ,('Apache Nine', '1.0.0.0', 'TRUE', GETDATE())
                                                      ,('KntLibrary', '1.0.0.0', 'FALSE',  GETDATE())";
            try
            {
                this._db.Execute(sql);
                Debug.Print("Setup success.");
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        #endregion

        #region Teardown

        [TestFixtureTearDown]
        public void Teardown()
        {
            string sql = "DELETE FROM PRODUCTS";

            try
            {
                this._db.Execute(sql);
                Debug.Print("Teardown success.");
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        #endregion

        [Test]
        public void TestSave_WhenCommited()
        {
            var model = new Product() 
            {
                Name = "Hoge",
                Version = "1.0.0.0",
                EnableFlag = true
            };

            bool result = model.Save();
            Assert.IsTrue(result);
        }

        private static readonly object[] TestCases = 
        {
            new object[] {3, new Condition() { Name = "", EnableFlag = null } },
            new object[] {2, new Condition() { Name = "", EnableFlag = true } },
            new object[] {1, new Condition() { Name = "", EnableFlag = false } },
            new object[] {1, new Condition() { Name = "Apache", EnableFlag = null } },
            new object[] {1, new Condition() { Name = "Apache", EnableFlag = true }},
            new object[] {0, new Condition() { Name = "Apache", EnableFlag = false } },
        };

        /// <summary>
        /// FindProductsByメソッドテスト
        /// 期待結果:3件分の取得データ
        /// </summary>
        [TestCaseSource("TestCases")]
        public void TestFindProductsBy(int expected, Condition condition)
        {
            var data = new Product().FindProductsBy(condition);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
