using DapperWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebApi.Repository
{
    interface IRepository
    {
        List<User> GetUsers(int amount, string sort);
        User GetUser(int id);
        bool InsertUser(User user);
        bool DeleteUser(User user);
    }
}
