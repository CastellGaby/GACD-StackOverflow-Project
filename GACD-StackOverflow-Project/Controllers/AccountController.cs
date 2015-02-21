using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using GACD_StackOverflow_Project.Models;

namespace GACD_StackOverflow_Project.Controllers
{
   
    public class AccountController : Controller
    {
        /*----------------Login--------------------------------*/
        public ActionResult Login()
        {
            var model = new AccountLoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(AccountLoginModel modelLogin)
        {/*
            if (ModelState.IsValid)
            {
                return RedirectToAction()
            }*/
            var modelo2 =new AccountRegisterModel();

            return View(modelLogin);
        }

        /*public ActionResult LogOut()
        {
            //falta
            //FormsAuthentication.SignOut();
            //return RedirectToAction("Index", "Question");
        }*/

        /*----------------Register-----------------------------*/
        public ActionResult Register()
        {
            var model = new AccountRegisterModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(AccountRegisterModel modelRegister)
        {
            return View(modelRegister);
        }

        /*----------------PassworRecovery-----------------------------*/
        public ActionResult PasswordRecovery()
        {
            var model = new AccountPasswordRecoveryModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult PasswordRecovery(AccountPasswordRecoveryModel modelPasswprdRecovery)
        {
            return View(modelPasswprdRecovery);
        }

        /*----------------Profile------------------------------------*/
        public ActionResult Profile()
        {
            var model = new AccountProfileModel();
            return View(model);
        }
    }
}