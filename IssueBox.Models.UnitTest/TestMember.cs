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

        private static readonly object[] TestCases = 
        {
            new object[] {3, new Condition() { Name = "", EnableFlag = null } },
            new object[] {2, new Condition() { Name = "", EnableFlag = true } },
            new object[] {1, new Condition() { Name = "", EnableFlag = false } },
            new object[] {1, new Condition() { Name = "Yamada", EnableFlag = null } },
            new object[] {1, new Condition() { Name = "Yamada", EnableFlag = true } },
            new object[] {0, new Condition() { Name = "Yamada", EnableFlag = false } }
        };

        /// <summary>
        /// FindMembersByメソッドテスト
        /// 比較条件:期待値と取得件数
        /// </summary>
        /// <param name="expected">期待値</param>
        /// <param name="condition">検索条件</param>
        [TestCaseSource("TestCases")]
        public void TestFindMembersBy(int expected, Condition condition)
        {
            var data = Member.FindMembersBy(condition);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
