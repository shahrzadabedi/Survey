
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
            return agentDAO.getSurveyAgent().GetAllSurveys(status);            
        }

        public void Add(SurveyDTO dto)
        {
             agentDAO.getSurveyAgent().Add(dto);
        }

    }
}
