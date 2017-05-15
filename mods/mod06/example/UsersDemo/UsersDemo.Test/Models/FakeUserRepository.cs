using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersDemo.Models;

namespace UsersDemo.Test.Models
{
    public class FakeUserRepository : IUserRepository
    {

        private List<User> db = new List<User>();

        //public Exception ExceptionToThrow { get; set; }

        /// <summary>
        /// ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return this.db.ToList();
        }

        public User GetById(int id)
        {
            return this.db.FirstOrDefault(d => d.ID == id);
        }

        public void Create(User user)
        { 
            this.db.Add(user);
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            User user = GetById(id);
            this.db.Remove(user);
        }

        public void SaveChanges(User user)
        {

            foreach (User u in this.db)
            {
                if (u.ID == user.ID)
                {
                    this.db.Remove(u);
                    this.db.Add(user);
                    break;
                }
            }
        }

        public int SaveChanges()
        {
            return 1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
