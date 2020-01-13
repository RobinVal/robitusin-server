using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ConversationMemberRepository
    {

        public List<ConversationMember> FindAll()
        {
            return MyContext.Get().Members.ToList();
        }

        public ConversationMember FindById(int Id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return MyContext.Get().Members.Find(Id);
        }

        public void Create(ConversationMember member)
        {
            MyContext.Get().Members.Add(member);
            MyContext.Get().SaveChanges();
        }

        public void Update(ConversationMember member)
        {
            MyContext.Get().Entry(member).State = System.Data.Entity.EntityState.Modified;
            MyContext.Get().SaveChanges();
        }

        public void Delete(ConversationMember member)
        {
            MyContext.Get().Members.Remove(member);
            MyContext.Get().SaveChanges();
        }
    }
}