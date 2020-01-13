using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Models.Conversation
{
    public class ConversationRepository
    {

        public List<Conversation> FindAll()
        {
            return MyContext.Get().Conversations?.ToList();
        }

        public Conversation FindById(int Id)
        {

            return MyContext.Get().Conversations.Find(Id);
        }

        public void Create(Conversation conversation)
        {
            MyContext.Get().Conversations.Add(conversation);
            MyContext.Get().SaveChanges();
        }

        public void Update(Conversation conversation)
        {
            MyContext.Get().Entry(conversation).State = System.Data.Entity.EntityState.Modified;
            MyContext.Get().SaveChanges();
        }

        public void Delete(Conversation conversation)
        {
            MyContext.Get().Conversations.Remove(conversation);
            MyContext.Get().SaveChanges();
        }
    }
}