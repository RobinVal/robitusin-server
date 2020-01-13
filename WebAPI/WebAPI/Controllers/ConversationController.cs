using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models.Conversation;

namespace WebAPI.Controllers
{
    public class ConversationController : ApiController
    {
        private ConversationRepository repository = new ConversationRepository();

        // GET: api/Conversation
        public IEnumerable<Conversation> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/Conversation/5
        public Conversation Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        // POST: api/Conversation
        public void Post([FromBody]Conversation value)
        {
            this.repository.Create(value);

        }

        // PUT: api/Conversation/5
        public void Put(int Id, [FromBody]Conversation value)
        {
            value.Id = Id;
            this.repository.Update(value);
        }

        // DELETE: api/Conversation/5
        public void Delete(int Id)
        {
            Conversation conversation = this.repository.FindById(Id);
            this.repository.Delete(conversation);
        }
    }
}
