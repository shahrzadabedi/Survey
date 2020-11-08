using Survey.Business.Mapper;
using Survey.Ef.DB;
using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
   internal  class SurveyService :ISurveyService
    {         
        
        private IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.User_Survey> context;
        public SurveyService() {
           this.context = new SurveyEfDbContextLocator();
        }
        public GetSurveysByStatusResponse  GetAll(SurveyStatus status)
        {
            GetSurveysByStatusResponse result = new GetSurveysByStatusResponse();
                       
            var surveys = context.SurveyRep().Get(p => p.State == (int)status)
                .Select(p => p.MapObject<Domain.Survey>())
                .ToList();
            ////TODO seperate different user types
            result.Surveys = surveys;
            return result;
        }

    }
}
