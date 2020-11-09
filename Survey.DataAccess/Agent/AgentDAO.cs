using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    internal class AgentDAO : IAgentDAO
    {
        private ISurveyDAO SurveyDAO;
        private IUserDAO UserDAO;
        public AgentDAO(ISurveyDAO surveyDAO,IUserDAO userDAO)
        {
            this.SurveyDAO = surveyDAO;
            this.UserDAO = userDAO;
        }
        public ISurveyDAO getSurveyAgent()
        {
            return SurveyDAO;
        }

        public IUserDAO getUserAgent()
        {
            return UserDAO;
        }
    }
}
