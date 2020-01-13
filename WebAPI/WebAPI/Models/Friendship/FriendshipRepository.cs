using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Friendship
{
    public class FriendshipRepository
    {
        private FriendshipContext context = new FriendshipContext();

        public List<Friendship> FindAll()
        {
            return this.context.Friendships.ToList();
        }

        public Friendship FindById(int Id)
        {

            return this.context.Friendships.Find(Id);
        }

        public void Create(Friendship friendship)
        {
            this.context.Friendships.Add(friendship);
            this.context.SaveChanges();
        }

        public void Update(Friendship friendship)
        {
            this.context.Entry(friendship).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Friendship friendship)
        {
            this.context.Friendships.Remove(friendship);
            this.context.SaveChanges();
        }
    }
}