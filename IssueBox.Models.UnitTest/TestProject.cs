using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    public class TestProject
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestProject()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO PROJECTS VALUES ('FL999-0001', '案件A', 'TRUE', GETDATE())
                                                      ,('FL999-0002', '案件B', 'FALSE', GETDATE())
                                                      ,('FL999-0003', '案件C', 'TRUE', GETDATE())";
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
            string sql = "DELETE FROM PROJECTS";

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

        private static readonly List<EquipmentConfiguration> _newEquipConf = new List<EquipmentConfiguration>() 
        {
            new EquipmentConfiguration() { ProjectID = 0, EquipName = "TypeA", MakerName = "MakerA", Rating = 100.0m,  UnitCount = 1, IrrTempFlag = true},
            new EquipmentConfiguration() { ProjectID = 0, EquipName = "TypeB", MakerName = "MakerA", Rating = 100.0m,  UnitCount = 3, IrrTempFlag = true},
            new EquipmentConfiguration() { ProjectID = 0, EquipName = "TypeC", MakerName = "MakerA", Rating = 100.0m,  UnitCount = 4, IrrTempFlag = false}
        };

        private static readonly List<EquipmentConfiguration> _updEquipConf = new List<EquipmentConfiguration>() 
        {
            new EquipmentConfiguration() { ID = 1, ProjectID = 1, EquipName = "TypeA", MakerName = "MakerB", Rating = 120.0m, UnitCount = 1, IrrTempFlag = true}
        };

        private static readonly object[] SaveTestCases = 
        {
            new object[] { true, new Project(){ ProjectID = "TEST999-9999", Name = "Foo", EnableFlag = true}, _newEquipConf },
            new object[] { true, new Project(){ ID = 4, ProjectID = "TEST999-9999", Name = "Foo", EnableFlag = true}, _updEquipConf },
            new object[] { false, new Project(){ ProjectID = "", Name = "Foo", EnableFlag = true}, _newEquipConf }
        };

        [TestCaseSource("SaveTestCases")]
        public void TestSave(bool expected, Project arg1, List<EquipmentConfiguration> arg2)
        {
            bool result = false;

            try
            {
                result = arg1.Save(arg2);
            }
            catch(Exception ex)
            {
                result = false;
                Debug.Print(ex.Message);
            }

            Assert.AreEqual(expected, result);
        }

        private static readonly object[] TestCases = 
        {
            new object[] {3, new ProjectCondition() { ProjectID = "", Name = "", EnableFlag = "all" } },
            new object[] {2, new ProjectCondition() { ProjectID = "", Name = "", EnableFlag = "true" } },
            new object[] {1, new ProjectCondition() { ProjectID = "", Name = "", EnableFlag = "false" } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "", EnableFlag = "all" } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "", EnableFlag = "true" } },
            new object[] {0, new ProjectCondition() { ProjectID = "FL999-0001", Name = "", EnableFlag = "false" } },
            new object[] {1, new ProjectCondition() { ProjectID = "", Name = "A", EnableFlag = "all" } },
            new object[] {1, new ProjectCondition() { ProjectID = "", Name = "A", EnableFlag = "true" } },
            new object[] {0, new ProjectCondition() { ProjectID = "", Name = "A", EnableFlag = "false" } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "A", EnableFlag = "all" } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "A", EnableFlag = "true" } },
            new object[] {0, new ProjectCondition() { ProjectID = "FL999-0001", Name = "A", EnableFlag = "false" } }
        };

        /// <summary>
        /// FindProjectsByメソッドテスト
        /// 比較条件:期待値と取得件数
        /// </summary>
        /// <param name="expected">期待値</param>
        /// <param name="condition">検索条件</param>
        [TestCaseSource("TestCases")]
        public void TestFindProjectsBy(int expected, ProjectCondition condition)
        {
            var data = Project.FindProjectsBy(condition);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
