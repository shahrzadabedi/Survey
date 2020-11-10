using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class SurveyAnswerHistory
    {
      public int Id { get; set; }
      public string UserName { get; set; }
      public int AnswerStatus { get; set; }
      public DateTime AnswerDateTime { get; set; }
      public SurveyDTO Survey { get; set; }
    }
}
