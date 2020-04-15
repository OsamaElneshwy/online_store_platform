using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SWE2.Models
{
    public class ApplicationUser
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        private const string ConnectionString =
            "LocalDb";

        public ApplicationDbContext() : base(ConnectionString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}