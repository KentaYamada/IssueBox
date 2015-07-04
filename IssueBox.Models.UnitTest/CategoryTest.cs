using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    [TestFixture]
    public class CategoryTest
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public CategoryTest()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO CATEGORIES VALUES ('原因調査', 'TRUE', GETDATE())
                                                        ,('プログラム開発', 'FALSE', GETDATE())
                                                        ,('出荷設定', 'TRUE', GETDATE())";
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
            string sql = "DELETE FROM CATEGORIES";

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

        /// <summary>
        /// Saveメソッドテスト
        /// 期待結果:Transaction commited
        /// </summary>
        [Test]
        public void TestSaveWhenCommited()
        {
            var model = new Category()
            {
                Name = "Hoge",
                EnableFlag = true
            };

            bool result = model.Save();
            Assert.IsTrue(result);
        }

        /// <summary>
        /// FindCategoriesByメソッドテスト
        /// 期待結果:3件分の取得データ
        /// </summary>
        [Test]
        public void TestFindCategoriesByNoCondition()
        {
            var condition = new Condition();
            var data = new Category().FindByCategories(condition);
            Assert.AreEqual(3, data.Count);
        }

        [Test]
        public void TestFindCategoriesByEnabledData()
        {
            var condition = new Condition()  { EnableFlag = true };
            var data = new Category().FindByCategories(condition);
            Assert.AreEqual(2, data.Count);

        }

        [Test]
        public void TestFindCategoriesByName()
        {
            var condition = new Condition() { Name = "原因", EnableFlag = null };
            var data = new Category().FindByCategories(condition);
            Assert.AreEqual(1, data.Count);
        }

        [Test]
        public void TestFindCategoriesByAllCondition()
        {
            var condition = new Condition() { Name = "出荷", EnableFlag = true };
            var data = new Category().FindByCategories(condition);
            Assert.AreEqual(1, data.Count);
        }

        [Test]
        public void TestFindCategoriesBy_WhenSearchNoData()
        {
            var condition = new Condition() { Name = "出荷", EnableFlag = false };
            var data = new Category().FindByCategories(condition);
            Assert.AreEqual(0, data.Count);
        }
    }
}
