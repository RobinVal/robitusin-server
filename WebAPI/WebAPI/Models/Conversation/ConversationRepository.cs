using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Conversation
{
    public class ConversationRepository
    {
        private ConversationContext context = new ConversationContext();

        public List<Conversation> FindAll()
        {
            return this.context.Conversations.ToList();
        }

        public Conversation FindById(int Id)
        {

            return this.context.Conversations.Find(Id);
        }

        public void Create(Conversation conversation)
        {
            this.context.Conversations.Add(conversation);
            this.context.SaveChanges();
        }

        public void Update(Conversation conversation)
        {
            this.context.Entry(conversation).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Conversation conversation)
        {
            this.context.Conversations.Remove(conversation);
            this.context.SaveChanges();
        }
    }
}