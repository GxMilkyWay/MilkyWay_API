using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DapperDEmoInASP.NET.Interface
{
    interface IDBConnectionClass
    {
        IDbConnection OpenConnection();
    }
}

////for calling 
// IDBConnectionClass cc = new DBConnectionClass();

//        public void abc()
//        {
//            //using (IDbConnection db = StaticConnClass.OpenConnection())
//            using (IDbConnection db = cc.OpenConnection())
//            {
//                var param = new DynamicParameters();
//                string query = @"insert into TblCustomer (CustomerName,CustomerAddress,EmailId,MobileNo,CountryID,StateID) values('sa','Bhopal','nausad@gmail.com','12345678',1,2)";
//                int id = db.Execute(query);

//            }

//        }