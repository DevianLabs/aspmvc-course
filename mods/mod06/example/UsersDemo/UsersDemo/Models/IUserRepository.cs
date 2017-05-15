using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersDemo.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void Create(User user);

        void Edit(User user);

        void Delete(int id);

        int SaveChanges();

        void Dispose();
    }
}