using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
   public interface ISurveyQAnswer
    {
         int Id { get; set; }
         QuestionDTO Question { get; set; }
         short Answer { get; set; }
         SurveyDTO Survey { get; set; }
         int LastSuveyAnswerStatus { get; set; }
         DateTime UserAnswerDateTime { get; set; }
    }
}
