using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class SurveyDto : ISurvey
    {
        public int Id { get; set; }
        public int Duration { get; set; }
     
        public string CreatorUserName { get; set; }    
        public DateTime CreateDateTime { get; set; }
        public int State { get; set; }
        public SurveyStatus Status{ get { return (SurveyStatus)State; }  }

        public ICollection<QuestionDTO> Questions { get  ; set  ; }
        public ICollection<UserAnswerDTO> UserAnswers { get  ; set  ; }
    
    }
}
