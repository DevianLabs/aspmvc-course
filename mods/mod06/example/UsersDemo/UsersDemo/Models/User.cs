using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace UsersDemo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }

        [Display(Name="Nombre")]
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }

        //[DisplayFormat(DataFormatString = "0:{dd/MM/yyyy}")]
        public DateTime Birthdate { get; set; }
        public decimal Weight { get; set; }

    }

    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserDbContext") { }

        public IDbSet<User> Users { get; set; }
    }
}