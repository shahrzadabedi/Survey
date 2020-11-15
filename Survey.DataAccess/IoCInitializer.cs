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
            Container.Register<IEFRepositoryLocator<Domain.Survey, Domain.UserAnswer, Domain.Question, Domain.Answer>, SurveyEfDbContextLocator>(Lifestyle.Scoped);
           // Container.Register<IUserDAO, UserDAO>(Lifestyle.Scoped);
           // Container.Register<IAgentDAO, AgentDAO>(Lifestyle.Scoped);
        }
    }
}
