using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ConversationMemberController : ApiController
    {
        private ConversationMemberRepository repository = new ConversationMemberRepository();

        // GET: api/ConversationMember
        public IEnumerable<ConversationMember> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/ConversationMember/5
        public ConversationMember Get(int Id)
        {
            return this.repository.FindById(Id);
        }

        // POST: api/ConversationMember
        public void Post([FromBody]ConversationMember value)
        {
            this.repository.Create(value);

        }

        // PUT: api/ConversationMember/5
        public void Put(int Id, [FromBody]ConversationMember value)
        {
            value.Id = Id;
            this.repository.Update(value);
        }

        // DELETE: api/ConversationMember/5
        public void Delete(int Id)
        {
            ConversationMember member = this.repository.FindById(Id);
            this.repository.Delete(member);
        }
    }
}
