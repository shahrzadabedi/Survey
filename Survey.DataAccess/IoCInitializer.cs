using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
   public class IoCInitializer
    {
        public void Initialize(Container Container)
        {
            Container.Register<ISurveyDAO, SurveyDAO>(Lifestyle.Scoped);
            Container.Register<IUserDAO, UserDAO>(Lifestyle.Scoped);
            Container.Register<IAgentDAO, AgentDAO>(Lifestyle.Scoped);
        }
    }
}
