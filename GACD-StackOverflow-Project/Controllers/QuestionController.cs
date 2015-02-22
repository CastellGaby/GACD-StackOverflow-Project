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
            QuestionListModel modelIndex = new QuestionListModel();
            modelIndex.Title = "Why so searius?";
            modelIndex.OwnerUsername = "CastellDraco";
            modelIndex.Votes = 5;
            modelIndex.CreationDateQuestion = DateTime.Now;
            modelIndex.OwnerUserId = Guid.NewGuid();
            modelIndex.QuestionId = Guid.NewGuid();
            models.Add(modelIndex);

            return View(modelIndex);
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