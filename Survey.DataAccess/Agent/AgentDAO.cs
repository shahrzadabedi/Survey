using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    internal class AgentDAO : IAgentDAO
    {
        private ISurveyAgentDAO SurveyDAO;
        private IUserDAO UserDAO;
        public AgentDAO(ISurveyAgentDAO surveyDAO,IUserDAO userDAO)
        {
            this.SurveyDAO = surveyDAO;
            this.UserDAO = userDAO;
        }
        public ISurveyAgentDAO GetSurveyAgent()
        {
            return SurveyDAO;
        }

        public IUserDAO GetUserAgent()
        {
            return UserDAO;
        }
    }
}
