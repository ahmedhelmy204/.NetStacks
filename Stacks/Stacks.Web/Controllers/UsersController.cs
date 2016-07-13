using Stacks.Web.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stacks.Web.Controllers
{
    public class UsersController : Controller
    {
        #region Sign Up

        // GET: /Users/SignUp
        [HttpGet]
        public ActionResult SignUp()
        {
            UsersRegister model = new UsersRegister();
            return View(model);
        }

        // POST: /Users/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UsersRegister model)
        {

            return View(model);
        }

        #endregion Sign Up
    }
}