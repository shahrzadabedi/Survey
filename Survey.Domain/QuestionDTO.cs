using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class QuestionDTO : IQuestion
    {
        public SurveyDto Survey { get ; set; }
        public int Id { get; set ; }
        public int QId { get ; set; }
        public string QDesc { get ; set ; }
    }
}
