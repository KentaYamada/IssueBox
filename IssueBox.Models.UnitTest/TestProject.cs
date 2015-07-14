using System;
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

        [Test]
        public void TestSave()
        {
            var model = new Project() 
            {
                ProjectID = "FL999-0004",
                Name = "Hoge",
                EnableFlag = true
            };

            bool result = model.Save();
            Assert.IsTrue(result);
        }

        private static readonly object[] TestCases = 
        {
            new object[] {3, new ProjectCondition() { ProjectID = "", Name = "", EnableFlag = -1 } },
            new object[] {2, new ProjectCondition() { ProjectID = "", Name = "", EnableFlag = 1 } },
            new object[] {1, new ProjectCondition() { ProjectID = "", Name = "", EnableFlag = 0 } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "", EnableFlag = -1 } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "", EnableFlag = 1 } },
            new object[] {0, new ProjectCondition() { ProjectID = "FL999-0001", Name = "", EnableFlag = 0 } },
            new object[] {1, new ProjectCondition() { ProjectID = "", Name = "A", EnableFlag = -1 } },
            new object[] {1, new ProjectCondition() { ProjectID = "", Name = "A", EnableFlag = 1 } },
            new object[] {0, new ProjectCondition() { ProjectID = "", Name = "A", EnableFlag = 0 } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "A", EnableFlag = -1 } },
            new object[] {1, new ProjectCondition() { ProjectID = "FL999-0001", Name = "A", EnableFlag = 1 } },
            new object[] {0, new ProjectCondition() { ProjectID = "FL999-0001", Name = "A", EnableFlag = 0 } }
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
