
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using SWE2.Models;

namespace SWE2.Controllers
{
    public class UserController : ApiController
    {


       


        [Route("Register")]
        public string Register(int id , string email,string password, string role)
        {
            if(role == "Admin" || role == "Customer" || role == "StoreOwner" )
            {
                var context = new ApplicationDbContext();
                context.ApplicationUsers.Add(new ApplicationUser
                {
                    Email = email,
                    Id = id,
                    Password = password,
                    Role = role
                });
                context.SaveChanges();
                return "Added successfully";
            }
            else
            {
                return "Check your data";
            }
             
        }




    }
}
