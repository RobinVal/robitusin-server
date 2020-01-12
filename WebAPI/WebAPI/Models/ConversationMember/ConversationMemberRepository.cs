using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ConversationMemberRepository
    {
        private ConMemContext context = new ConMemContext();

        public List<ConversationMember> FindAll()
        {
            return this.context.Members.ToList();
        }

        public ConversationMember FindById(int Id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return this.context.Members.Find(Id);
        }

        public void Create(ConversationMember member)
        {
            this.context.Members.Add(member);
            this.context.SaveChanges();
        }

        public void Update(ConversationMember member)
        {
            this.context.Entry(member).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(ConversationMember member)
        {
            this.context.Members.Remove(member);
            this.context.SaveChanges();
        }
    }
}