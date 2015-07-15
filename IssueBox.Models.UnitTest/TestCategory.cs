using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    [TestFixture]
    public class TestCategory
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestCategory()
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

        private static readonly object[] TestCases = 
        {
            new object[] {3, new Condition() { Name = "", EnableFlag = "all" } },
            new object[] {2, new Condition() { Name = "", EnableFlag = "true" } },
            new object[] {1, new Condition() { Name = "", EnableFlag = "false" } },
            new object[] {1, new Condition() { Name = "原因", EnableFlag = "all" } },
            new object[] {1, new Condition() { Name = "原因", EnableFlag = "true" }},
            new object[] {0, new Condition() { Name = "原因", EnableFlag = "false" } },
        };

        /// <summary>
        /// FindCategoriesByメソッドテスト
        /// 比較条件:期待値と取得件数
        /// </summary>
        /// <param name="expected">期待値</param>
        /// <param name="condition">検索条件</param>
        [TestCaseSource("TestCases")]
        public void TestFindCategoriesBy(int expected, Condition condition)
        {
            var data = Category.FindByCategories(condition);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
