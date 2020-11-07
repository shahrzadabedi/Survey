using Survey.Business.Mapper;
using Survey.DataAccess;
using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
   public  class SurveyService :ISurveyService
    {         
        
        private IEFRepositoryLocator<DataAccess.Survey,DataAccess.User_Survey> context;
        public SurveyService() {
           this.context = new SurveyEfDbContextLocator();
        }
        public GetSurveysByStatusResponse  GetAll(GetSurveysByStatusRequest request)
        {
            GetSurveysByStatusResponse result = new GetSurveysByStatusResponse();
                       
            var surveys = context.SurveyRep().Get(p => p.State == (int)request.Status)
                .Select(p => p.MapObject<Domain.Survey>())
                .ToList();
            ////TODO seperate different user types
            result.Surveys = surveys;
            return result;
        }

    }
}
