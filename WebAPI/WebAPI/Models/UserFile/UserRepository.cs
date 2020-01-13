using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Models
{
    public class UserRepository
    {
        private MyContext context = new MyContext();

        public List<User> FindAll()
        {
            return this.context.Users.ToList();
        }

        public User FindById(int Id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return this.context.Users.Find(Id);
        }

        public void Create(User user)
        {
            this.context.Users.Add(user);
            //this.context.SaveChanges();
        }

        public void Update(User user)
        {
        

            this.context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(User user)
        {
            this.context.Users.Remove(user);
            this.context.SaveChanges();
        }
        public User FindByUserName(string name)
        {
            return this.context.Users.Where(u => u.Username == name).First();
        }
    }
}
