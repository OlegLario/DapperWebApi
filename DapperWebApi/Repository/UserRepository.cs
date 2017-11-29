using DapperWebApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace DapperWebApi.Repository
{    
    public class UserRepository : IRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public List<User> GetUsers(int amount, string sort)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            return _db.Query<User>(@"SELECT[UserId] FROM [User] WHERE UserId = @UserId", new { UserId = userId }).FirstOrDefault();
        }

        public bool InsertUser(User user)
        {
            var rows = this._db.Execute(@"INSERT User([FName],[LName],[IsActive]) values (@FName, @LName, @IsActive)", new { FName = user.FName, LName = user.LName, IsActive = true});
            if (rows > 0)
                return true;
            else
                return false;      
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }


    }
}