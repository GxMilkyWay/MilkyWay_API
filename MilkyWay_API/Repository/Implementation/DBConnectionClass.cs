using MilkyWay_API.Contract;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MilkyWay_API.Repository.Implementation
{
    public class DBConnectionClass : IDBConnectionClass
    {
        public IDbConnection OpenConnection()

        {
            IDbConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
