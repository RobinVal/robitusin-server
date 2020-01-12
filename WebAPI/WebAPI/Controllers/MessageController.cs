using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Models.Message;

namespace WebAPI.Controllers
{
    public class MessageController : ApiController
    {
        private MessageRepository repository = new MessageRepository();

        // GET: api/ConversationMember
        public IEnumerable<Message> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/ConversationMember/5
        public Message Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        // POST: api/ConversationMember
        public void Post([FromBody]Message value)
        {
            this.repository.Create(value);

        }

        // PUT: api/ConversationMember/5
        public void Put(int Id, [FromBody]Message value)
        {
            value.Id = Id;
            this.repository.Update(value);
        }

        // DELETE: api/ConversationMember/5
        public void Delete(int Id)
        {
            Message message = this.repository.FindById(Id);
            this.repository.Delete(message);
        }
    }
}
