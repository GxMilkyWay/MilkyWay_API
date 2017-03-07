using MilkyWay_API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;
using MilkyWay_API.Repository.Contract;
using MilkyWay_API.Utility;
using Security;

namespace MilkyWay_API.Repository.Implementation
{
    public class LoginRepository : ILogin
    {
        IDbConnection _conn;
        DBConnectionClass objConn = new DBConnectionClass();
        public bool VerifyLogin(LoginData obj)
        {
            //obj.Username = "TS3W1Fp9K455KiYZg6bWVg==";//nausad133
           // obj.Password = "K8P6MlyNotBnmEQteYyMMw==";//nausad           
            this._conn = objConn.OpenConnection();
            //string strPassword = _conn.Query<string>("select Password from TBLLogin where Username='" + AESEncrytDecry.DecryptStringAES(obj.Username) + "'").FirstOrDefault();
           
            string strPassword = _conn.Query<string>("select Password from TBLLogin where Username='" + obj.Username + "'").FirstOrDefault();
            if (strPassword == null)
                return false;
            if (AESEncrytDecry.DecryptStringAES(strPassword) == AESEncrytDecry.DecryptStringAES(obj.Password))
                return true;
            else return false;

        }


        public bool AddUser(LoginData obj)
        {

            //       obj.Username="nausa";

            //       DBConnectionClass objConn = new DBConnectionClass();
            //       this._conn = objConn.OpenConnection();
            //string query="insert into TBLLogin(Name,MobileNo,Email,Username,Password,UserType,IsActive,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy)"
            //       //+ "values(@Name,@MobileNo,@Email,@Username,@Password,@UserType,@IsActive,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)";
            //      + "values(@Name,@MobileNo,@Email,@Username,@Password,@UserType,@IsActive,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)";

            //_conn.Execute(query, new { obj.Username,"9630266959","nau_sad123","pass",1,1,DateTime.Now(),"nau",DateTime.Now(),"nau"});
            //       return true;
            var pass = AESEncrytDecry.EncryptStringToBytes("nausad123", SecurityKey.Keybytes(), SecurityKey.IVBytes());
            int b = 1;
            DBConnectionClass objConn = new DBConnectionClass();
            this._conn = objConn.OpenConnection();
            string query = "insert into TBLLogin(Name,MobileNo,Email,Username,Password,UserType,IsActive,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy)"
                  + "values('nausad','9630226959','nau@gmail.com','nausad123' ,'" + pass + " '," + b + "," + b + ",'" + System.DateTime.Now + "','Nausad','" + DateTime.Now + "' ,'nausad' )";
            _conn.Execute(query);
            return true;
        }


    }
}