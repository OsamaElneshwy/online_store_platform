using SWE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace SWE2.Controllers
{
    public class AdminController : UserController
    {
        // GET: Admin



        [Authorize(Roles = "Admin")]
        [Route("UserList")]
        public IEnumerable<ApplicationUser> GetUserList()
        {
            var ad = new Admin();
            return ad.UserList();

        }


    }
}