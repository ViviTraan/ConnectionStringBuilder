using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionStringBuilder.Builder
{
    public class ConnStringBuilder
    {
        public string Server { get; set; } 
        public string Database { get; set; } = "MyDatabase";
        public string DataSource { get; set; }
        public string Version { get; set; } = "3";
        public string Username { get; set; }
        public string Password { get; set; }

        public ConnStringBuilder SetServer(string server) 
        { 
            if(server != null)
                Server = server;
            return this;
        }
        public ConnStringBuilder SetDatabase(string database)
        {
            if(database != null)
                Database = database;
            return this;
        }
        public ConnStringBuilder SetUsername(string username) 
        { 
            if(username != null)
                Username = username;
            return this;
        }
        public ConnStringBuilder SetPassword(string password) 
        { 
            if(password != null)
                Password = password;
            return this;
        }
        public ConnStringBuilder SetDataSource(string dataSource)
        {
            if (dataSource != null)
                DataSource = dataSource;
            return this;
        }
        public ConnStringBuilder SetVersion(string version)
        {
            if (version != null)
                Version = version;
            return this;
        }

        public string BuildSqlServer()
        {
            if (Username == null)
                return $"Server={Server};Database={Database};Trusted_Connection=True;";
            else
                return $"Server={Server};Database={Database};User Id={Username};Password={Password};";
        }
        public string BuildMySql()
        {
                return $"Server={Server};Database={Database};Uid={Username};Pwd={Password};";
        }
        public string BuildSQLite()
        {
            
            if (Password == null)
                return $"Data Source={DataSource};Version={Version};";
            else
                return $"Data Source={DataSource};Version={Version};Password={Password};";
        }
        public string BuildMongoDB()
        {
            if (Username == null)
                return $"mongodb://{Server}/{Database}";
            else
                return $"mongodb://{Username}:{Password}@{Server}/{Database}";
        }
    }
}
