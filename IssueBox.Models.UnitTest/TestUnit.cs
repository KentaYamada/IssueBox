using System;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    public class TestUnit
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestUnit()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO UNITS VALUES ('kW', 'TRUE', GETDATE())
                                                   ,('Hz','FALSE', GETDATE())
                                                   ,('V','TRUE', GETDATE())";
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
            string sql = "DELETE FROM UNITS";

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

        #region Test FindUnitsBy function

        private static readonly object[] FindUnitsByTestCases = 
        {
            new object[] {3, new Condition() { Name = "", EnableFlag = "all" } },
            new object[] {2, new Condition() { Name = "", EnableFlag = "true" } },
            new object[] {1, new Condition() { Name = "", EnableFlag = "false" } },
            new object[] {1, new Condition() { Name = "kW", EnableFlag = "all" } },
            new object[] {1, new Condition() { Name = "kW", EnableFlag = "true" }},
            new object[] {0, new Condition() { Name = "kW", EnableFlag = "false" } },
        };

        [TestCaseSource("FindUnitsByTestCases")]
        public void TestFindUnitsBy(int expected, Condition condition)
        {
            var data = Unit.FindUnitsBy(condition);
            Assert.AreEqual(expected, data.Count);
        }

        #endregion

        #region Test Save function

        private static readonly object[] SaveTestCases = 
        {
            new object[] { true, new Unit() { ID = 0, Name = "test", EnableFlag = true } },
            new object[] { false, new Unit() { ID = 0, Name = null, EnableFlag = false } },
            new object[] { true, new Unit() { ID = 1, Name = "upd_test", EnableFlag = true } },
            new object[] { false, new Unit() { ID = 0, Name = null, EnableFlag = true } }
        };

        [TestCaseSource("SaveTestCases")]
        public void TestSave(bool expected, Unit target)
        {
            bool result = false;

            try
            {
                result = target.Save();
            }
            catch
            {
                result = false;
            }

            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}
