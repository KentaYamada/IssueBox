using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    public class TestMember
    {
        private readonly SQLCommander _db = null;
        
        #region Default constructor

        public TestMember()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO MEMBERS VALUES ('Suzuki Ichiro', 'suzuki', 'test', 'TRUE', GETDATE())
                                                     ,('Yamada Taro', 'yamada', 'test', 'TRUE', GETDATE())
                                                     ,('Tanaka Goro', 'tanaka', 'test', 'FALSE',  GETDATE())";
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
            string sql = "DELETE FROM MEMBERS";

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
            var model = new Member() 
            {
                Name = "Hoge",
                LoginID = "hoge",
                LoginPassword = "test",
                EnableFlag = true
            };

            bool result = model.Save();
            Assert.IsTrue(result);
        }

        /// <summary>
        /// FindMembersByメソッドテスト
        /// 比較条件:期待値と取得件数
        /// </summary>
        /// <param name="name">メンバー名</param>
        /// <param name="enableFlag">有効可否</param>
        /// <param name="expected">期待値</param>
        [TestCase("", null, 3)]
        [TestCase("", true, 2)]
        [TestCase("Yamada", null, 1)]
        [TestCase("Yamada", true, 1)]
        [TestCase("Yamada", false, 0)]
        public void TestFindMembersBy(string name, bool? enableFlag, int expected)
        {
            var condition = new Condition() { Name = name, EnableFlag = enableFlag };
            var data = new Member().FindMembersBy(condition);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
