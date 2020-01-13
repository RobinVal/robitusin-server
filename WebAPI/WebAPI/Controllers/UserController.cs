using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        
        private UserRepository repository = new UserRepository();
        
        [HttpPost]
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

        // GET: api/User/5
        public User Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        // POST: api/User
        public void Post([FromBody]User value)
        {
            this.repository.Create(value);
            
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
