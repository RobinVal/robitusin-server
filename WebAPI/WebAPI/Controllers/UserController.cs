using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Models.UserFile;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        
        int IDe = 1;
        private UserRepository repository = new UserRepository();

        [Route("api/User/Login")]
        public User Login([FromBody]Models.LoginInput loginInput)
        {
            User user = repository.FindByUserName(loginInput.Username);
            if (user.Password == loginInput.Password)
            {
                return user;
            } 
            
                throw new UnauthorizedAccessException();
            
        }

        // GET: api/User
        public IEnumerable<User> Get()
        {
            return this.repository.FindAll();
        }
        // GET: api/User/Username
        public User GetByUsername(string username)
        {
            return this.repository.FindByUserName(username);
        }
        // GET: api/User/5
        public User Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        [Route("api/User/Register")]
        public void Post([FromBody]RegisterInput value)
        {
            User novy = new User();
            
            novy.Username = value.Username;
            novy.Password = value.Password;
            novy.Email = value.Email;
            novy.ProfileImage = value.ProfileImage;
            novy.Token = value.Token;
            novy.Id = ++IDe;

            this.repository.Create(novy);

        }

        // PUT: api/User/5
        public void Put(int Id, [FromBody]User value)
        {
            value.Id = Id;
            this.repository.Update(value);
        }

        // DELETE: api/User/5
        public void Delete(int Id)
        {
            User user = this.repository.FindById(Id);
            this.repository.Delete(user);
        }
    }
}
