using SWE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWE2.Controllers
{
    public class AdminController : AccountController
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult AdminHome()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult UesrsList()
        {
            Admin a = new Admin();
            return View(a.getUsers());
        }

        [AllowAnonymous]
        public ActionResult SetAdmin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SAdmin(SetAdminViewModel model)
        {
            string mail = model.Email;
            Admin a = new Admin();
            a.SetAdmin(mail);
            return View("SetAdmin");

        }







    }
}