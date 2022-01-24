using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConnectionStringBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionStringBuilder.Builder.Tests
{
    [TestClass()]
    public class ConnStringBuilderTests
    {
        [TestMethod()]
        public void BuildSqlServerTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "Server=localhost;Database=myDatabase;Trusted_Connection=True;";
            var actual = connectionStringBuilder.SetServer("localhost").SetDatabase("myDatabase").BuildSqlServer();
            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void BuildSqlServerWithUsernameTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "Server=localhost;Database=myDatabase;User Id=myUsername;Password=myPassword;";
            var actual = connectionStringBuilder.SetServer("localhost").SetDatabase("myDatabase").SetUsername("myUsername").SetPassword("myPassword").BuildSqlServer();
            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void BuildMySqlTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "Server=localhost;Database=myDatabase;Uid=myUsername;Pwd=myPassword;";
            var actual = connectionStringBuilder.SetServer("localhost").SetDatabase("myDatabase").SetUsername("myUsername").SetPassword("myPassword").BuildMySql();
            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void BuildSQLiteTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "Data Source=myDataSource;Version=3;";
            var actual = connectionStringBuilder.SetDataSource("myDataSource").SetVersion("3").BuildSQLite();
            Assert.AreEqual(exp, actual);
        }
        [TestMethod()]
        public void BuildSqLiteWithPasswordTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "Data Source=myDataSource;Version=3;Password=myPassword;";
            var actual = connectionStringBuilder.SetDataSource("myDataSource").SetVersion("3").SetPassword("myPassword").BuildSQLite();
            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void MongoDBTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "mongodb://myServer/myDatabase";
            var actual = connectionStringBuilder.SetServer("myServer").SetDatabase("myDatabase").BuildMongoDB();
            Assert.AreEqual(exp, actual);
        }
        [TestMethod()]
        public void MongoDBWithUsernameTest()
        {
            var connectionStringBuilder = new ConnStringBuilder();
            var exp = "mongodb://myUsername:myPassword@myServer/myDatabase";
            var actual = connectionStringBuilder.SetUsername("myUsername").SetPassword("myPassword").SetServer("myServer").SetDatabase("myDatabase").BuildMongoDB();
            Assert.AreEqual(exp, actual);
        }
    }
}