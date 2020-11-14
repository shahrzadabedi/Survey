using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    internal class SurveyDAO : ISurveyAgentDAO
    {
        private IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.UserAnswer,Ef.DB.Question> context;
        public SurveyDAO()
        {
            context = new SurveyEfDbContextLocator();
        }
        public List<SurveyDto> GetAllSurveys(SurveyStatus Status)
        {
            GetSurveysByStatusResponse result = new GetSurveysByStatusResponse();
            bool isAdmin = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).IsInRole("1");
            
            if (!isAdmin && (Status == SurveyStatus.New || Status == SurveyStatus.Edit))
                throw new Survey.Domain.Exceptions.DataAccessException("Survey");

            List<string> includeProperties = new List<string>();
            //includeProperties.Add("SurveyQAnswer");
            var surveys = context.SurveyRep().Get(p => ((SurveyStatus)p.State & Status) == (SurveyStatus)p.State,null,
                "UserAnswers")
                         .Select(p => p.MapObject())
                         .ToList();
           return surveys;
            
        }

        public void Add(SurveyDto dto)
        {
            bool isAdmin = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).IsInRole("1");
            if (!isAdmin)
                throw new Survey.Domain.Exceptions.InvalidOperaionException();
            context.SurveyRep().Insert(dto.MapObject());
            context.Save();
        }
        public bool SurveyHasBeenConductedBefore(SurveyDto dto) 
        {
            return context.SurveyQAnswerRep().Any(p => p.Survey.Id == dto.Id 
                                                    && (SurveyAnswerStatus)p.Survey.State == SurveyAnswerStatus.Complete);
                        
        }
    }
}
