using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace UsersDemo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Weight { get; set; }
    }

    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserDbContext") { }

        public DbSet<User> Users { get; set; }
    }
}