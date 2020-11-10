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
        public static SurveyDTO MapObject(this Models.SurveyModel model)
        {
            if (model == null)
                return null;
            SurveyDTO result = new SurveyDTO();
            result.Id = model.Id;
            result.Duration = model.Duration;
            result.CreateDateTime = model.CreateDateTime;
            result.State = model.State;
            result.Questions = model.Questions.Select(p => p.MapObject()).ToList();
            result.CreatorUserName = model.CreatorUserName;
            
            return result;
        }
        public static QuestionDTO MapObject(this Models.QuestionModel model)
        {
            if (model == null)
                return null;
            QuestionDTO res = new QuestionDTO();
            res.Id =model.Id;
            res.QId = model.QId;
            res.QDesc = model.QDesc;
            return res;
        }
        //public static Domain.Survey MapObject() { }
    }
}