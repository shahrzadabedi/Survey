using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Ef.DB
{
    public class SurveyQAnswer
    {
        public int Id { get; set; }
        public Question Question { get; set; }       
        public short Answer { get; set; }
        public Survey Survey { get; set; }
        public int LastSuveyAnswerStatus { get; set; }
        public DateTime UserAnswerDateTime { get; set; }
        

    }
}
