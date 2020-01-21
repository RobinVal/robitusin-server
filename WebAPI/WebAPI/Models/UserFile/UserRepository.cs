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
        
        public List<User> FindAll()
        {
            return MyContext.Get().Users.ToList();
        }

        public User FindById(int Id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return MyContext.Get().Users.Find(Id);
        }

        public void Create(User user)
        {
            MyContext.Get().Users.Add(user);
            
        }

        public void Update(User user)
        {


            MyContext.Get().Entry(user).State = System.Data.Entity.EntityState.Modified;
            MyContext.Get().SaveChanges();
        }

        public void Delete(User user)
        {
            MyContext.Get().Users.Remove(user);
            MyContext.Get().SaveChanges();
        }
        public User FindByUserName(string name)
        {
            return MyContext.Get().Users.Where(u => u.Username == name).First();
        }
    }
}
