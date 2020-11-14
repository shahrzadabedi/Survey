using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class UserAnswerDTO : IUserAnswer
    {
        public int Id { get; set; }
        public List<AnswerDTO> Question { get; set; }       
        public SurveyDto Survey { get; set; }
        //public int LastSuveyAnswerStatus { get; set; }
        //public DateTime UserAnswerDateTime { get; set; }
        public int AnswerStatus { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CompleteDateTime { get; set; }
        public DateTime UserLastAnswerDateTime { get; set; }
        public string UserName { get; set; }
    }
}
