using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ProfileImage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}