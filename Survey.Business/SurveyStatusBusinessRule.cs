using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
   public static class SurveyStatusBusinessRule
    {
        public static SurveyResultDto WithValidOperation(this Domain.Survey surveyDto)
        {
            if (surveyDto == null)
                return null;
            SurveyResultDto resu = new SurveyResultDto();
            resu.ValidOperations = new List<ValidOperation>();
            resu.Survey = surveyDto;
            switch (surveyDto.Status)
            {
                case SurveyStatus.New:
                    resu.ValidOperations.Add(ValidOperation.Open);
                    
                    break;
                case SurveyStatus.Edit:
                    resu.ValidOperations.Add(ValidOperation.Open);
                    break;
                case SurveyStatus.Open:
                    resu.ValidOperations.Add(ValidOperation.Close);
                    if (!surveyDto.UserAnswers.Any(p=> p.AnswerStatus == (int)SurveyAnswerStatus.Complete || p.AnswerStatus == (int)SurveyAnswerStatus.Initiated))
                        resu.ValidOperations.Add(ValidOperation.Edit);
                    break;
                case SurveyStatus.Closed:
                    break;
                default:
                    break;
            }
           
            return resu;
        }
    }
}
