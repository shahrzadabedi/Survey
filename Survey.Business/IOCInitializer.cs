using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
namespace Survey.Business
{
   public class IoCInitializer
    {
       
       public void Initialize( Container Container)
        {
            Container.Register<ISurveyService, SurveyService>(Lifestyle.Scoped);            
            //Container.Register(typeof(IRepository<>), typeof(BaseEFRepository<>).Assembly);
            //Container.Register<IEFRepositoryLocator<DataAccess.Survey, DataAccess.User_Survey>, SurveyEfDbContextLocator>(Lifestyle.Scoped);
        }
        
    }
}
