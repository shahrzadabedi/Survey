using System;
using System.Collections.Generic;

namespace Survey.WebAPI.Models
{
    public class UserAnswerModel
    {
       
        public int Id { get; set; }

        public SurveyModel Survey { get; set; }
        public int AnswerStatus { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CompleteDateTime { get; set; }
        public DateTime UserLastAnswerDateTime { get; set; }
        public string UserName { get; set; }
        ICollection<AnswerModel> Answers { get; set; }
    }
}