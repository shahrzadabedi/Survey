using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
   public interface ISurveyAnswerHistory
    {
       int Id { get; set; }
       string UserName { get; set; }
       int AnswerStatus { get; set; }
       DateTime AnswerDateTime { get; set; }
       SurveyDTO Survey { get; set; }
    }
}
