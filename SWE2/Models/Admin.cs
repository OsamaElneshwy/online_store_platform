using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SWE2.Models
{
    public class Admin : ApplicationUser
    {

        public IEnumerable<ApplicationUser> UserList()
        {
            var context = new ApplicationDbContext();
            return context.ApplicationUsers;
        }



    }
}