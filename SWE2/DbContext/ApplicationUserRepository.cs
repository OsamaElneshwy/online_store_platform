using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWE2.Models;

namespace SWE2.DbContext
{
    public class ApplicationUserRepository : IDisposable
    {
        ApplicationDbContext context = new ApplicationDbContext();
        //This method is used to check and validate the user credentials
        public ApplicationUser ValidateUser(string username, string password)
        {
            return context.ApplicationUsers.FirstOrDefault(user =>
                user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }
        public void Dispose()
        {
            context.Dispose();

        }
    }
}