
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
        private IAgentDAO agentDAO;
        public SurveyService(IAgentDAO agentDAO) {
           this.agentDAO = agentDAO;
        }
        public GetSurveysByStatusResponse GetAllSurveys(SurveyStatus status)
        {
            var surveyResults =  agentDAO.GetSurveyAgent().GetAllSurveys(status).Select(p=> p.WithValidOperation()).ToList();
            GetSurveysByStatusResponse result = new GetSurveysByStatusResponse();
            result.Surveys = surveyResults;
            return result;
        }

        public void Add(SurveyDto dto)
        {
             agentDAO.GetSurveyAgent().Add(dto);
        }
         
    }
}
