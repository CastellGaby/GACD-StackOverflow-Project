using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using AutoMapper;
using GACD_StackOverflow_Project.Models;
using MiniStackOverflow.DataDeployed;
using MiniStackOverflow.Domain.Entities;

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

            return View(models);

        }

        public ActionResult AskQuestion()
        {
            var model = new QuestionAskModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AskQuestion(QuestionAskModel modelAskQ)
        {
            AutoMapper.Mapper.CreateMap<Question, QuestionAskModel>().ReverseMap();
            Question newQuestion = AutoMapper.Mapper.Map<QuestionAskModel, Question>(modelAskQ);
            var question = Mapper.Map<QuestionAskModel, Question>(modelAskQ);

            var context = new MiniStackOverflowContext();
            context.Questions.Add(question);
            question.CreationDate = DateTime.Now;
            context.Questions.Add(question);
            
            context.SaveChanges();
            return RedirectToAction("Index", "Question");
        }

        
    }
}