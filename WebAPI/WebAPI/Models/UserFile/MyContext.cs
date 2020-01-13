using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        private static MyContext Self;

        public DbSet<User> Users { get; set; }
        public DbSet<Conversation.Conversation> Conversations { get; set; }

        public DbSet<Friendship.Friendship> Friendships { get; set; }
        public DbSet<Message.Message> Messages { get; set; }
        public DbSet<ConversationMember> Members { get; set; }

        private MyContext(){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static MyContext Get()
        {
            if(Self == null)
            {
                Self = new MyContext();
            }

            return Self;
        }
    }

}