using Survey.Business.Mapper;
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

namespace Survey.Business
{
   internal  class SurveyService :ISurveyService
    {
        private IAgentDAO agentDAO;
        public SurveyService(IAgentDAO agentDAO) {
           this.agentDAO = agentDAO;
        }
        public GetSurveysByStatusResponse  GetAll(SurveyStatus status)
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return agentDAO.getSurveyAgent().GetAll(status);            
        }

    }
}
