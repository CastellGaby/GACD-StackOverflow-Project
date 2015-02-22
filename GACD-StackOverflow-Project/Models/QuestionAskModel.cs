﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GACD_StackOverflow_Project.Models
{
    public class QuestionAskModel
    {
        [Required(ErrorMessage = "*Is required a title for your question")]
        public string Title { get; set; }
        [Required(ErrorMessage = "*Is required a description")]
        public string Description { get; set; }
       
        
    }
}