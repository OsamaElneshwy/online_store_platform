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
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }

    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        private const string ConnectionString = "SWEData";

        public ApplicationDbContext() : base(ConnectionString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}