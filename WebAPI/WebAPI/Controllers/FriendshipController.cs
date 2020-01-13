using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models.Friendship;

namespace WebAPI.Controllers
{
    public class FriendshipController : ApiController
    {
        private FriendshipRepository repository = new FriendshipRepository();

        // GET: api/Friendship
        public IEnumerable<Friendship> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/Friendship/5
        public Friendship Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        // POST: api/Friendship
        public void Post([FromBody]Friendship value)
        {
            this.repository.Create(value);

        }

        // PUT: api/Friendship/5
        public void Put(int Id, [FromBody]Friendship value)
        {
            value.Id = Id;
            this.repository.Update(value);
        }

        // DELETE: api/Friendship/5
        public void Delete(int Id)
        {
            Friendship friendship = this.repository.FindById(Id);
            this.repository.Delete(friendship);
        }
    }
}
