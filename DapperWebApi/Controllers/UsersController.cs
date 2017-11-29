using DapperWebApi.Models;
using DapperWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DapperWebApi.Controllers
{
    public class UsersController : ApiController
    {
        private UserRepository repo = new UserRepository();

        [Route("Users")]
        [HttpPost]
        public bool SetUser(User user)
        {
            return repo.InsertUser(user);
        }
    }
}
