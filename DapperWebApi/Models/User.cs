using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperWebApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool IsActive { get; set; }
    }
}