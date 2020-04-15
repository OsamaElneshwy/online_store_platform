using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWE2.Models;

namespace SWE2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            /* var context = new ApplicationDbContext();
             context.ApplicationUsers.Add(new ApplicationUser
             {
                 Email = "belal@h5a.com",Id = "1", Name = "belal",Password = "123",Role ="Admon", Username = "bll"
             });
             context.SaveChanges();*/
            return View();
        }
    }
}