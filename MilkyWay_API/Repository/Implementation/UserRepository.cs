using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilkyWay_API.Models;
using MilkyWay_API.Contract;
using System.Data;
using Dapper;

namespace MilkyWay_API.Repository.Implementation
{
    public class UserRepository : IGenericRepository<User>
    {
        IDbConnection _conn;

        public List<User> GetByParams(User obj)
        {
            throw new NotImplementedException();
        }
        public User Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            DBConnectionClass objConn = new DBConnectionClass();
            this._conn = objConn.OpenConnection();

            List<User> lstUser = _conn.Query<User>("select * from USER_MSTR").ToList();

            return lstUser;
        }

        bool IGenericRepository<User>.Add(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}