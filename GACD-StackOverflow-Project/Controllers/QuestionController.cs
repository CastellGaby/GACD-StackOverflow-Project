using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using GACD_StackOverflow_Project.Models;

namespace GACD_StackOverflow_Project.Controllers
{
    public class QuestionController : Controller
    {
        //
        // GET: /Question/
        public ActionResult Index()
        {

            List<QuestionListModel> models = new ListStack<QuestionListModel>();
            QuestionListModel modelTest = new QuestionListModel();
            modelTest.Title = "Why so serius?";
            modelTest.OwnerUsername= "CastellDraco";
            modelTest.Votes = 1;
            modelTest.CreationDateQuestion = DateTime.Now;
            modelTest.OwnerUserId = Guid.NewGuid();
            modelTest.QuestionId = Guid.NewGuid();

            models.Add(modelTest);
            QuestionListModel model2 = new QuestionListModel();
            model2.Title = "How do a excersice";
            model2.OwnerUsername = "LoboAcompañado";
            model2.Votes = 1;
            model2.CreationDateQuestion = DateTime.Now;
            model2.OwnerUserId = Guid.NewGuid();
            model2.QuestionId = Guid.NewGuid();

            models.Add(model2);
            //return View(new List<QuestionListModel>());
            return View(models);

        }

        public ActionResult AskQuestion()
        {
            var model = new QuestionAskModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AskQuestion(QuestionAskModel model)
        {
            return View(model);
        }
	}
}