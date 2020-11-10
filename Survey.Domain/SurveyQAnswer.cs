using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
   public class SurveyQAnswer: ISurveyQAnswer
    {
        public int Id { get; set; }
        public QuestionDTO Question { get; set; }
        public short Answer { get; set; }
        public SurveyDTO Survey { get; set; }
        public int LastSuveyAnswerStatus { get; set; }
        public DateTime UserAnswerDateTime { get; set; }
    }
}
