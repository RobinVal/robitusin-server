using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Message
{
    public class MessageRepository
    {
        private MessageContext context = new MessageContext();

        public List<Message> FindAll()
        {
            return this.context.Messages.ToList();
        }

        public Message FindById(int Id)
        {
           
            return this.context.Messages.Find(Id);
        }

        public void Create(Message messge)
        {
            this.context.Messages.Add(messge);
            this.context.SaveChanges();
        }

        public void Update(Message message)
        {
            this.context.Entry(message).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Message message)
        {
            this.context.Messages.Remove(message);
            this.context.SaveChanges();
        }
    }
}