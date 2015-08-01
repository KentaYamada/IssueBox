using System;
using System.Collections.Generic;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    [TestFixture]
    public class TestMaker
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestMaker()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO MAKERS VALUES ('Kawasaki', 'TRUE', GETDATE())
                                                    ,('YAMAHA', 'FALSE', GETDATE())
                                                    ,('SUBARU', 'TRUE', GETDATE())";
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
            string sql = "DELETE FROM MAKERS";

            try
            {
                this._db.Execute(sql);
                Debug.Print("Teardown success.");
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        #endregion

        private object[] FindMakersByTestCases = 
        {
            new object[] {3, new Condition() { Name = "", EnableFlag = "all" } },
            new object[] {2, new Condition() { Name = "", EnableFlag = "true" } },
            new object[] {1, new Condition() { Name = "", EnableFlag = "false" } },
            new object[] {1, new Condition() { Name = "Kawasaki", EnableFlag = "all" } },
            new object[] {1, new Condition() { Name = "Kawasaki", EnableFlag = "true" }},
            new object[] {0, new Condition() { Name = "Kawasaki", EnableFlag = "false" } },
        };

        [TestCaseSource("FindMakersByTestCases")]
        public void TestFindMakersBy(int expected, Condition condition)
        {
            var data = Maker.FindMakersBy(condition);
            Assert.AreEqual(expected, data.Count);
        }

        private static readonly List<Equipment> _equipments = new List<Equipment>() 
        {
            new Equipment() { Name = "TestEquipA", Rating = 100.0M, EnableFlag = true },
            new Equipment() { Name = "TestEquipB", Rating = 120.0M, EnableFlag = true },
            new Equipment() { Name = "TestEquipC", Rating = 150.5M, EnableFlag = true },
        };

        private object[] SaveTestCases = 
        {
            new object[] { true, new Maker() { Name = "SuccessData", EnableFlag = true }, _equipments },
            new object[] { false, new Maker() { Name = null, EnableFlag = true }, _equipments },
            new object[] { true, new Maker() { Name = "SuccessData", EnableFlag = true }, new List<Equipment>() },
            new object[] { false, new Maker() { Name = null, EnableFlag = true }, new List<Equipment>() },
        };

        [TestCaseSource("SaveTestCases")]
        public void TestSave(bool expected, Maker arg1, List<Equipment> arg2)
        {
            bool result = false;

            try
            {
                result = arg1.Save(arg2);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                result = false;
            }

            Assert.AreEqual(expected, result);
        }
    }
}
