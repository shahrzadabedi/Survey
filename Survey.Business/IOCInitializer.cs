﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Survey.DataAccess;

namespace Survey.Business
{
   public class IoCInitializer
    {
       
       public void Initialize(SimpleInjector.Container Container)
        {
            DataAccess.IoCInitializer initializer = new DataAccess.IoCInitializer();
            initializer.Initialize(Container);
            Container.Register<ISurveyService, SurveyService>(SimpleInjector.Lifestyle.Scoped);          
            
        }
        
    }
}
