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
           
        }
        
    }
}
