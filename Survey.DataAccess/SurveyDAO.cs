using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    internal class SurveyDAO : ISurveyDAO
    {
        private IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.User_Survey> context;
        public SurveyDAO()
        {
            context = new SurveyEfDbContextLocator();
        }
        public GetSurveysByStatusResponse GetAll(SurveyStatus Status)
        {
            GetSurveysByStatusResponse result = new GetSurveysByStatusResponse();

            var surveys = context.SurveyRep().Get(p => p.State == (int)Status)
                .Select(p => p.MapObject<Domain.Survey>())
                .ToList();
            ////TODO seperate different user types
            result.Surveys = surveys;
            return result;
        }
    }
}
