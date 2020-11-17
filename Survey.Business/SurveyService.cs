
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
        public async Task<List<SurveyResultDto>> GetAllSurveys(SurveyStatus status)
        {           
            bool isAdmin = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).IsInRole("1");

            if (!isAdmin && (status == SurveyStatus.New || status == SurveyStatus.Edit))
                throw new Survey.Domain.Exceptions.DataAccessException("Survey");           

            var surveys = await context.SurveyRep().GetAsync(p => (p.Status & status) == p.Status, null,
                p => p.UserAnswers,
                p => p.Questions                );            
            var surveyResults = surveys.Select(p=> p.WithValidOperation()).ToList();
            return surveyResults;
        }

        public async Task Add(Domain.Survey dto)
        {
            // Interception => IOC (SimpleInjector, AOP, Logging)
            //Log.LogINfo(dto);
            bool isAdmin = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).IsInRole("1");
            if (!isAdmin)
                throw new Survey.Domain.Exceptions.InvalidOperaionException();
             context.SurveyRep().Insert(dto);
           await  context.Save();
            //Log.LogInfo("Add Successfully executed");
        }
        public bool SurveyHasBeenConductedBefore(Domain.Survey dto)
        {
            return context.UserAnswerRep().Any(p => p.Survey.Id == dto.Id
                                                    && (((SurveyAnswerStatus)p.AnswerStatus == SurveyAnswerStatus.Complete) ||
                                                    ((SurveyAnswerStatus)p.AnswerStatus == SurveyAnswerStatus.Initiated)));

        }

        public async Task<SurveyResultDto> Get(int Id)
        {
            var survey = await context.SurveyRep().GetAsync(p => p.Id == Id, null, p => p.UserAnswers,
               p => p.Questions);                                    
                 
           return survey.FirstOrDefault() == null ? null :survey.FirstOrDefault().WithValidOperation();
        }
    }
}
