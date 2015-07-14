using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    public class TestIssue
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestIssue()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO ISSUES VALUES (1, GETDATE(), 1, 1, 1, 1, 1, GETDATE(), 1, 'test', GETDATE())
                                                    ,(1, GETDATE(), 1, 1, 1, 1, 1, GETDATE(), 1, 'hoge', GETDATE())
                                                    ,(1, GETDATE(), 1, 1, 1, 1, 1, GETDATE(), 1, 'fuga', GETDATE())";
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
            string sql = "DELETE FROM ISSUES";

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
        public void TestSave()
        {
            var model = new Issue() 
            {
                ProjectID = 1,
                OriginationDate = DateTime.Now,
                CategoryID = 1,
                ProductID = 1,
                IssuingMemberID = 1,
                ResponcedMemberID = 1,
                CheckedMemberID = 1,
                Deadline = DateTime.Now.AddDays(7),
                Status = 1,
                FinishedDate = null,
                Comment = "test"
            };

            bool result = model.Save();
            Assert.IsTrue(result);
        }
    }
}
