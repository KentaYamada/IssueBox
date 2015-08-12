using System;
using System.Data.SqlClient;
using System.Diagnostics;

using NUnit.Framework;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models.UnitTest
{
    /// <summary>
    /// DBアクセスクラステスト
    /// </summary>
    [TestFixture]
    public class TestSQLCommander
    {
        private readonly SQLCommander _db = null;

        public TestSQLCommander()
        {
            this._db = new SQLCommander();
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            //Create test table
            this._db.Execute("create table Test(id int, name nvarchar(20))");
            Debug.Print("Table created.");

            //Insert Test data
            string insSql = "insert into Test(id, name) values (1, 'hoge'), (2, 'fuga'), (3, 'foo')";
            this._db.Execute(insSql);
            Debug.Print("Insert data success.");

            //Create stored procedure
            string selectProc = "create procedure GetData (@ID int) as begin select * from Test where id = @ID end";
            this._db.Execute(selectProc);
            Debug.Print("Create GetData function success.");

            string updProc = "create procedure UpdateData(@ID int, @Name nvarchar(20)) as begin update Test set name = @Name where id = @ID end";
            this._db.Execute(updProc);
            Debug.Print("Create UpdateData function success.");
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            string dropGetData = "drop procedure dbo.GetData";
            this._db.Execute(dropGetData);
            Debug.Print("Delete GetData function success.");

            string dropProc = "drop procedure dbo.UpdateData";
            this._db.Execute(dropProc);
            Debug.Print("Delete UpdateData function success.");

            this._db.Execute("drop table Test");
            Debug.Print("Table deleted.");
        }


        [Test]
        public void TestExecuteProcedure()
        {
            bool result = false;
            var model = new Test(1, "updated");
            try
            {
                result = this._db.Execute("Exec UpdateData @ID, @Name", model) > 0 ? true : false;
            }
            catch
            {
                result = false;
            }

            Assert.AreEqual(true, result);
        }
    }

    public class Test
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Test()
            :this(0,"")
        { }

        public Test(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
