using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    [TestFixture]
    public class TestEquipment
    {
        private readonly SQLCommander _db = null;

        #region Default constructor

        public TestEquipment()
        {
            this._db = new SQLCommander();
        }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void Setup()
        {
            string sql = @"INSERT INTO EQUIPMENTS VALUES ('KMG-20', 20.0, 1,'TRUE', GETDATE())
                                                        ,('KP-230R', 100.0, 0,'FALSE', GETDATE())
                                                        ,('KSD-447V', 9.9, 1, 'TRUE', GETDATE())";
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
            string sql = "DELETE FROM EQUIPMENTS";

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
        /// 機器一覧取得テスト
        /// </summary>
        /// <param name="expected">期待値</param>
        /// <param name="makerID">(検索条件)メーカーID</param>
        [TestCase(2, 1)]
        [TestCase(1, 0)]
        [TestCase(0, 2)]
        public void TestFindEquipmentsBy(int expected, int makerID)
        {
            var data = Equipment.FindEquipmentsBy(makerID);
            Assert.AreEqual(expected, data.Count);
        }
    }
}
