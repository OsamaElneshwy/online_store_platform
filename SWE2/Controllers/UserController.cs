
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
        [Route("h5a/app/h5a")]
        public IEnumerable<ApplicationUser> Geth5a()
        {
            var context= new ApplicationDbContext();
            return context.ApplicationUsers;
        }
    }
}
