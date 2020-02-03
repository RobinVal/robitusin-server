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

        // GET: api/Message
        public IEnumerable<Message> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/Message/5
        public Message Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        // POST: api/Message
        public void Post([FromBody]Message value)
        {
            this.repository.Create(value);

        }

        // PUT: api/Message/5
        public void Put(int Id, [FromBody]Message value)
        {
            value.Id = Id;
            this.repository.Update(value);
        }

        // DELETE: api/Message/5
        public void Delete(int Id)
        {
            Message message = this.repository.FindById(Id);
            this.repository.Delete(message);
        }

        [Route("api/Message/MessageByConversationId/{id}")]
        [HttpGet]
        public IEnumerable<Message> MessageByConversationId (int id)
        {
           
             return this.repository.FindByConversationId(2);
        }

    }
}
