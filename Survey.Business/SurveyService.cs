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
        // public static readonly SurveyService Instance = new SurveyService();
        public IDbContextLocator contextLocator;
        private DbContext dbContext;
        public SurveyService() {
            this.contextLocator = new SurveyDbContextLocator();
            dbContext = contextLocator.Get();
        }
        public GetSurveysByStatusResponse  GetAll(GetSurveysByStatusRequest request)
        {
            GetSurveysByStatusResponse result = new GetSurveysByStatusResponse();
            //var surveys = ((BaseEFRepository<DataAccess.Survey>)unit.Surveys)
            //    .Get(p => p.State == (int)request.Status)
            //    .Select(p => p.MapObject<Domain.Survey>())
            //    .ToList();
           
           var surveys =  new BaseEFRepository<DataAccess.Survey>(dbContext).Get(p => p.State == (int)request.Status)
                .Select(p => p.MapObject<Domain.Survey>())
                .ToList();
            ////TODO seperate different user types
            result.Surveys = surveys;
            return result;
        }

    }
}
