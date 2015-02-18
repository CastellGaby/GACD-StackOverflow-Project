using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GACD_StackOverflow_Project.Models;

namespace GACD_StackOverflow_Project.Controllers
{
    public class AccountLoginController : Controller
    {
        //
        // GET: /AccountLogin/
        public ActionResult Login()
        {
            var model =new AccountLoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(AccountLoginModel modelLogin)
        {
            return View(modelLogin);
        }


	}
}