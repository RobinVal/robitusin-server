using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Models.Friendship
{
    public class FriendshipRepository
    {
        

        public List<Friendship> FindAll()
        {
            return MyContext.Get().Friendships.ToList();
        }

        public Friendship FindById(int Id)
        {

            return MyContext.Get().Friendships.Find(Id);
        }

        public void Create(Friendship friendship)
        {
            MyContext.Get().Friendships.Add(friendship);
            MyContext.Get().SaveChanges();
        }

        public void Update(Friendship friendship)
        {
            MyContext.Get().Entry(friendship).State = System.Data.Entity.EntityState.Modified;
            MyContext.Get().SaveChanges();
        }

        public void Delete(Friendship friendship)
        {
            MyContext.Get().Friendships.Remove(friendship);
            MyContext.Get().SaveChanges();
        }
    }
}