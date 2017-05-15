using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UsersDemo.Models
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext db = new UserDbContext();

       public IEnumerable<User> GetAll()
        {
            return this.db.Users;
        }

        public User GetById(int id)
        {
            return this.db.Users.Find(id);
        }
        
        public void Create(User user)
        {
            this.db.Users.Add(user);
            this.db.SaveChanges();
        }

        public void Edit(User user)
        {
            this.db.Entry(user).State = EntityState.Modified;
            this.db.SaveChanges();
        }
        
        public void Delete(int id)
        {
            User user = this.db.Users.Find(id);
            this.db.Users.Remove(user);
            this.db.SaveChanges();
        }

        public int SaveChanges()
        {
            return this.db.SaveChanges();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}