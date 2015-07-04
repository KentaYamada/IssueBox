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
    public class ProductTest
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public ProductTest()
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

        /// <summary>
        /// FindProductsByメソッドテスト
        /// 期待結果:3件分の取得データ
        /// </summary>
        [Test]
        public void TestFindProductsByNoCondition()
        {
            var condition = new Condition();
            var data = new Product().FindProductsBy(condition);
            Assert.AreEqual(3, data.Count);
        }

        [Test]
        public void TestFindProductsByEnabledData()
        {
            var condition = new Condition() { EnableFlag = true };
            var data = new Product().FindProductsBy(condition);
            Assert.AreEqual(2, data.Count);

        }

        [Test]
        public void TestFindProductsByName()
        {
            var condition = new Condition() { Name = "Apache", EnableFlag = null };
            var data = new Product().FindProductsBy(condition);
            Assert.AreEqual(1, data.Count);
        }

        [Test]
        public void TestFindProductsByAllCondition()
        {
            var condition = new Condition() { Name = "Apache", EnableFlag = true };
            var data = new Product().FindProductsBy(condition);
            Assert.AreEqual(1, data.Count);
        }

        [Test]
        public void TestFindProductsBy_WhenSearchNoData()
        {
            var condition = new Condition() { Name = "Apache", EnableFlag = false };
            var data = new Product().FindProductsBy(condition);
            Assert.AreEqual(0, data.Count);
        }
    }
}
