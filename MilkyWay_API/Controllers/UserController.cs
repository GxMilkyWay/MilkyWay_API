using MilkyWay_API.Models;
using MilkyWay_API.Repository.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MilkyWay_API.Controllers
{
    [RoutePrefix("Regis")]
    public class UserController : ApiController
    {
        UserRepository _userRep;

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
