using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using GACD_StackOverflow_Project.Models;
using MiniStackOverflow.DataDeployed;
using MiniStackOverflow.Domain.Entities;

namespace GACD_StackOverflow_Project.Controllers
{
   
    public class AccountController : Controller
    {

        public AccountController()
        {
            
        }
        readonly IMappingEngine _mappingEngine;
        public AccountController(IMappingEngine mappingEngine)
        {
            _mappingEngine = mappingEngine;
        }

        /*----------------Login--------------------------------*/
        public ActionResult Login()
        {
            var model = new AccountLoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(AccountLoginModel modelLogin)
        {

            var context = new MiniStackOverflowContext();
            var account = context.Accounts.FirstOrDefault(x => x.E_mail == modelLogin.E_mail && x.Password == modelLogin.Password);
            if (account != null)
            {
                FormsAuthentication.SetAuthCookie(modelLogin.E_mail, false);
                return RedirectToAction("Index", "Question");
            }
            
            return View(modelLogin);
        }

        public ActionResult LogOut()
        {
            
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Question");
        }

        /*----------------Register-----------------------------*/
        public ActionResult Register()
        {
            var model = new AccountRegisterModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(AccountRegisterModel modelRegister)
        {
            if (ModelState.IsValid)
            {

                AutoMapper.Mapper.CreateMap<Account, AccountRegisterModel>().ReverseMap();
                Account newAccount = AutoMapper.Mapper.Map<AccountRegisterModel, Account>(modelRegister);
 
                var account = Mapper.Map<AccountRegisterModel,Account>(modelRegister);

                var context = new MiniStackOverflowContext();
                context.Accounts.Add(account);
                context.SaveChanges();
                return RedirectToAction("Login");

            }

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