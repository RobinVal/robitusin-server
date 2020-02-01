using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Message
{
    public class MessageRepository
    {
        

        public List<Message> FindAll()
        {
            return MyContext.Get().Messages.ToList();
        }

        public Message FindById(int Id)
        {
           
            return MyContext.Get().Messages.Find(Id);
        }

        public void Create(Message messge)
        {
            MyContext.Get().Messages.Add(messge);
            MyContext.Get().SaveChanges();
        }

        public void Update(Message message)
        {
            MyContext.Get().Entry(message).State = System.Data.Entity.EntityState.Modified;
            MyContext.Get().SaveChanges();
        }

        public void Delete(Message message)
        {
            MyContext.Get().Messages.Remove(message);
            MyContext.Get().SaveChanges();
        }
        public List<Message> FindByConversationId(int id)
        {
            return MyContext.Get().Messages.Where(m => m.ConversationId == id).ToList();
        }
    }
}