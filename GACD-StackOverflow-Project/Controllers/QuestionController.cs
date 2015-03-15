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

        UnitOfWork unitOfWork=new UnitOfWork();
        public ActionResult Index()
        {

            List<QuestionListModel> models = new ListStack<QuestionListModel>();
            
            //De la entidad Question lo guardo a un Modelo QuestionList
            Mapper.CreateMap<Question, QuestionListModel>();
            var questions = unitOfWork.QuestionRepository.Get();

            foreach (var quest in questions )
            {
                var qmodel = Mapper.Map<Question, QuestionListModel>(quest);
                models.Add(qmodel);
            }

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