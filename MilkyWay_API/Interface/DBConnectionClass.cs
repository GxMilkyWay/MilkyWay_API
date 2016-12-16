using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperDEmoInASP.NET.Interface
{
    public class DBConnectionClass : IDBConnectionClass
    {

        public IDbConnection OpenConnection()
        {
            IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBstring"].ConnectionString);
            connection.Open();
            return connection;
        }

    }
}
