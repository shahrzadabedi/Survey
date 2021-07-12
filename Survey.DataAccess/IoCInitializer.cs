
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
        public void Initialize(SimpleInjector.Container Container)
        {
            Container.Register<IEFRepositoryLocator<Domain.Survey, Domain.UserAnswer, Domain.Question, Domain.Answer>, SurveyEfDbContextLocator>(Lifestyle.Scoped);
            
            /// commit change 2 to remote master
        }
    }
}
