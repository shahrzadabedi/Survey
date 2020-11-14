using Survey.Domain;
using Survey.Ef.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
   public static class SurveyMapper
    {
        public static SurveyDto MapObject(this Ef.DB.Survey model)
        {
            if (model == null)
                return null;
            SurveyDto result = new SurveyDto();
            result.Id = model.Id;
            result.Duration = model.Duration;
            result.CreateDateTime = model.CreateDateTime;
            result.State = model.State;
            result.Questions = (model.Questions ?? new List<Question>()).Select(p => p.MapObject()).ToList();
            result.CreatorUserName = model.CreatorUserName;
            result.UserAnswers = (model.UserAnswers ?? new List<UserAnswer>()).Select(p => p.MapObject()).ToList();
            return result;
        }

        public static Ef.DB.Survey MapObject(this SurveyDto model)
        {
            if (model == null)
                return null;
            Ef.DB.Survey result = new Ef.DB.Survey();
            result.Id = model.Id;
            result.Duration = model.Duration;
            result.CreateDateTime = model.CreateDateTime;
            result.State = model.State;
            result.Questions = (model.Questions ?? new List<QuestionDTO>()).Select(p => p.MapObject()).ToList();
            result.CreatorUserName = model.CreatorUserName;
            
            return result;
        }
        public static QuestionDTO MapObject(this Ef.DB.Question model)
        {
            if (model == null)
                return null;
            QuestionDTO res = new QuestionDTO();
            res.Id = model.Id;
            res.QId = model.QId;
            res.QDesc = model.QDesc;
            return res;
        }

        public static Ef.DB.Question MapObject(this QuestionDTO model)
        {
            if (model == null)
                return null;
            Ef.DB.Question res = new Ef.DB.Question();
            res.Id = model.Id;
            res.QId = model.QId;
            res.QDesc = model.QDesc;
            return res;
        }
        public static UserAnswerDTO MapObject(this Ef.DB.UserAnswer model)
        {
            if (model == null)
                return null;
            UserAnswerDTO res = new UserAnswerDTO();
            res.UserLastAnswerDateTime = model.UserLastAnswerDateTime;
            res.Id = model.Id;
            res.StartDateTime = model.StartDateTime;
            res.CompleteDateTime = model.CompleteDateTime;
            return res;
        }
        //public static Domain.Survey MapObject() { }
    }
}
