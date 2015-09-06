using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    [TestFixture]
    public class TestCommunicationMethod
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestCommunicationMethod()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO COMMUNICATION_METHOD VALUES ('RS485', 'TRUE', GETDATE())
                                                                  ,('Modbus', 'FALSE', GETDATE())
                                                                  ,('TCP/IP', 'TRUE', GETDATE())";
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
            string sql = "DELETE FROM COMMUNICATION_METHOD";

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

        private static readonly object[] TestCases = 
        {
            new object[] {3, new Condition() { Name = "", EnableFlag = "all" } },
            new object[] {2, new Condition() { Name = "", EnableFlag = "true" } },
            new object[] {1, new Condition() { Name = "", EnableFlag = "false" } },
            new object[] {1, new Condition() { Name = "RS485", EnableFlag = "all" } },
            new object[] {1, new Condition() { Name = "RS485", EnableFlag = "true" }},
            new object[] {0, new Condition() { Name = "RS485", EnableFlag = "false" } },
        };

        /// <summary>
        /// FindCategoriesByメソッドテスト
        /// 比較条件:期待値と取得件数
        /// </summary>
        /// <param name="expected">期待値</param>
        /// <param name="condition">検索条件</param>
        [TestCaseSource("TestCases")]
        public void TestFindCommunicationMethodBy(int expected, Condition condition)
        {
            var data = CommunicationMethod.FindCommunicationMethodBy(condition);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
