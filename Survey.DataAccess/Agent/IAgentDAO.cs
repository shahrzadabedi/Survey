using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
   public interface IAgentDAO
    {
        ISurveyDAO getSurveyAgent();
        IUserDAO getUserAgent();
    }
}
