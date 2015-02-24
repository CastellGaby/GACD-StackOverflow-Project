using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MiniStackOverflow.Domain.Entities;

namespace GACD_StackOverflow_Project.Models
{
    public class QuestionDetailModel
    {
        
        public string Title { get; set; }
       
        public string Description { get; set; }
        public string OwnerUsername { get; set; }
       
        [DataType(DataType.DateTime)]
        public DateTime CreationDateQuestion { get; set; }
        public int Votes { get; set; }

        public IEnumerable<Question> QuestionEnum { get; set; }
    }
}