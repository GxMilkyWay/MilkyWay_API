using MilkyWay_API.Models;
using MilkyWay_API.Repository.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BCrypt.Net; 

namespace MilkyWay_API.Controllers
{
    [RoutePrefix("Regis")]
    [EnableCors(origins: "*", headers: "Access-Control-Allow-Origin", methods: "*")]
    public class UserController : ApiController
    {
        UserRepository _userRep;
        LoginRepository _lgnRep;

         //GET: api/User
        [HttpPost, Route("Verify")]
        public bool VerifyLogin(LoginData LoginData)
        {
             
            //LoginData lgn = new LoginData();
            //lgn.Username = password;
            //lgn.Password = password;

            _lgnRep = new LoginRepository();
            // var result = _lgnRep.AddUser(LoginData);
           var result = _lgnRep.VerifyLogin(LoginData);
           return result;
        }

        // GET: api/User
        //[Route("Verify/{password}")]
        //[HttpGet]
        //public int VerifyLogin(string password)
        //{
        //    LoginData lgn = new LoginData();
        //    lgn.Username = password;
        //    //lgn.Password = password;

        //    _lgnRep = new LoginRepository();
        //    //  var result=_lgnRep.GetByParams(lgn);
        //    return 1;
        //}
        

        // GET: api/User
        //[Route("User123")]
        [ActionName("GetUser")]
        [HttpGet]
        public IEnumerable<User> Get()
        {
            _userRep = new UserRepository();
            return _userRep.GetAll();
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/User
        [Route("User")]
        [HttpGet]
        public string PostGet([FromBody]User objUser)
        {
            return "HI";
        }


        // POST: api/User
        [Route("User")]
        [HttpPost]
        public void Post([FromBody]User objUser)
        {

        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
