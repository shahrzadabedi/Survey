using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class SurveyDTO : ISurvey
    {
        public List<ValidOperation> ValidOperations { get; set; }
        public int Id { get; set; }
        public int Duration { get; set; }
     
        public string CreatorUserName { get; set; }    
        public DateTime CreateDateTime { get; set; }
        
        private int _state ;
        public int State { get { return _state; } set { _state = value;  } }
        public SurveyStatus Status{ get { return (SurveyStatus)State; }  }

        public ICollection<QuestionDTO> Questions { get  ; set  ; }
        public ICollection<SurveyQAnswer> SurveyQAnswers { get  ; set  ; }
        public ICollection<SurveyAnswerHistory> SurveyAnswerHistory { get  ; set  ; }
    }
}
