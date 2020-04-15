using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWE2.Controllers
{
    public class CustomerController : AccountController
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult CustomerHome()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }




    }
}