
//using Survey.Ef.DB;
using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survey.DataAccess;
using System.Threading;
using System.Data.Entity.Migrations.Model;

namespace Survey.Business
{
   internal  class SurveyService :ISurveyService
    {
        private IEFRepositoryLocator<Domain.Survey, Domain.UserAnswer, Domain.Question, Domain.Answer> context;
        public SurveyService(IEFRepositoryLocator<Domain.Survey, Domain.UserAnswer, Domain.Question, Domain.Answer> context) {
            this.context = context;
                //new SurveyEfDbContextLocator();
        }
        public List<SurveyResultDto> GetAllSurveys(SurveyStatus status)
        {           
            bool isAdmin = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).IsInRole("1");

            if (!isAdmin && (status == SurveyStatus.New || status == SurveyStatus.Edit))
                throw new Survey.Domain.Exceptions.DataAccessException("Survey");

            List<string> includeProperties = new List<string>();

            var surveys = context.SurveyRep().Get(p => (p.Status & status) == p.Status, null, 
                p => p.UserAnswers,
                p=> p.Questions

                )                     
                 .ToList();
            var surveyResults = surveys.Select(p=> p.WithValidOperation()).ToList();
            return surveyResults;
        }

        public void Add(Domain.Survey dto)
        {
            bool isAdmin = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).IsInRole("1");
            if (!isAdmin)
                throw new Survey.Domain.Exceptions.InvalidOperaionException();
            context.SurveyRep().Insert(dto);
            context.Save();
        }
        public bool SurveyHasBeenConductedBefore(Domain.Survey dto)
        {
            return context.UserAnswerRep().Any(p => p.Survey.Id == dto.Id
                                                    && (((SurveyAnswerStatus)p.AnswerStatus == SurveyAnswerStatus.Complete) ||
                                                    ((SurveyAnswerStatus)p.AnswerStatus == SurveyAnswerStatus.Initiated)));

        }

        public SurveyResultDto Get(int Id)
        {
            var survey = context.SurveyRep().Get(p => p.Id == Id, null, p => p.UserAnswers,
               p => p.Questions)
               .FirstOrDefault();                     
                 
           return survey== null ? null :survey.WithValidOperation();
        }
    }
}
