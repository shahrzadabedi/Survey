using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey.WebAPI
{
    public static class SurveyMapper
    {
        public static TSurvey MapObject<TSurvey>(this Domain.ISurvey obj)
            where TSurvey : ISurvey, new()
        {
            TSurvey result = (TSurvey)(obj);
            return result;

        }
        public static Domain.Survey MapObject(this Models.SurveyModel model)
        {
            if (model == null)
                return null;
            Domain.Survey result = new Domain.Survey();
            result.Id = model.Id;
            result.Duration = model.Duration;
            result.CreateDateTime = model.CreateDateTime;
            result.Status = model.Status;
            result.Questions = model.Questions.Select(p => p.MapObject()).ToList();
            result.CreatorUserName = model.CreatorUserName;
            
            return result;
        }

        public static Models.SurveyModel MapObject(this SurveyResultDto survey) 
        {
            if (survey == null || survey.Survey==null)
                return null;
           var o = survey.Survey;
            Models.SurveyModel result = new Models.SurveyModel();
            result.Id = o.Id;
            result.Duration = o.Duration;
            result.CreateDateTime = o.CreateDateTime;
            result.Status = o.Status;
            result.Questions = o.Questions.Select(p => p.MapObject()).ToList();
            result.UserAnswers = o.UserAnswers.Select(p => p.MapObject()).ToList();
            result.CreatorUserName = o.CreatorUserName;
            result.ValidOperations = survey.ValidOperations;
            return result;
        }
        public static Question MapObject(this Models.QuestionModel model)
        {
            if (model == null)
                return null;
            Question res = new Question();
            res.Id =model.Id;
            res.QId = model.QId;
            res.QDesc = model.QDesc;
            return res;
        }

        public static Models.QuestionModel MapObject(this Question q)
        {
            if (q == null)
                return null;
            Models.QuestionModel res = new Models.QuestionModel();
            res.Id = q.Id;
            res.QId = q.QId;
            res.QDesc = q.QDesc;
            return res;
        }

        public static UserAnswer MapObject(this Models.UserAnswerModel model)
        {
            if (model == null)
                return null;
            UserAnswer res = new UserAnswer();
            res.CompleteDateTime = model.CompleteDateTime;
            res.Id = model.Id;
            res.StartDateTime = model.StartDateTime;
            res.CompleteDateTime = model.CompleteDateTime;
            res.UserLastAnswerDateTime = model.UserLastAnswerDateTime;
            res.UserName = model.UserName;
            
            return res;
        }
        public static Models.UserAnswerModel MapObject(this UserAnswer q)
        {
            if (q == null)
                return null;
            Models.UserAnswerModel res = new Models.UserAnswerModel();
            res.CompleteDateTime = q.CompleteDateTime;
            res.Id = q.Id;
            res.StartDateTime = q.StartDateTime;
            res.CompleteDateTime = q.CompleteDateTime;
            res.UserLastAnswerDateTime = q.UserLastAnswerDateTime;
            res.UserName = q.UserName;
            
            return res;
        }
        //public static Domain.Survey MapObject() { }
    }
}