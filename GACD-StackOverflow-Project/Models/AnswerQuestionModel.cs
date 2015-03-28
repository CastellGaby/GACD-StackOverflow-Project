using System;

namespace GACD_StackOverflow_Project.Models
{
    public class AnswerQuestionModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid OwnerId { get; set; }
        public Guid QuestionId { get; set; }
        public DateTime CreationDate { get; set; }

    }
}