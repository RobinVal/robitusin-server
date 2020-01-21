using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.UserFile
{
    public class RegisterInput
    {
        public string Username { get; set; }
        public string ProfileImage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}