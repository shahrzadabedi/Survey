using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace Survey.WebAPI.Models
{
    public class AnswerModel 
    {
        public int Id { get; set; }
        public QuestionModel Question { get; set; }
        public UserAnswerModel UserAnswer { get; set; }
        public short Value { set; get; }
    }
}