// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Survey.WebAPI.DependencyResolution {
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using global::Survey.Business;
    using StructureMap;
    

    public class DefaultRegistry : Registry {
      

        // --------------------------------------------------------------------------------------------------------------------
        // <copyright file="DefaultRegistry.cs" company="Web Advanced">
        // Copyright 2012 Web Advanced (www.webadvanced.com)
        // Licensed under the Apache License, Version 2.0 (the "License");
        // you may not use this file except in compliance with the License.
        // You may obtain a copy of the License at
        //
        // http://www.apache.org/licenses/LICENSE-2.0

        // Unless required by applicable law or agreed to in writing, software
        // distributed under the License is distributed on an "AS IS" BASIS,
        // WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
        // See the License for the specific language governing permissions and
        // limitations under the License.
        // </copyright>
        // --------------------------------------------------------------------------------------------------------------------

   

        
            #region Constructors and Destructors

            public DefaultRegistry()
            {
                Scan(
                    scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.WithDefaultConventions();

                        //this line of code is just directions telling structuremap 
                        //where to look for dal models.  
                        //typically, my dal code lives in different class library
                        //scan.AssemblyContainingType<SurveyDbContextLocator>();
                        //scan.AssemblyContainingType<DbContext>();
                        //to connect implementations to our open generic type of irepository, 
                        //we use the connectimplementationstotypesclosing method.  
                        // scan.ConnectImplementationsToTypesClosing(typeof(IUnitOfWork));
                    });
                //For<IDbContextLocator>().Use(ctx => new SurveyDbContextLocator());
                For(typeof(ISurveyService)).Use(typeof(SurveyService));
                //For<IExample>().Use<Example>();
                //For<IDbContextLocator>().Use(ctx => new SurveyDbContextLocator());
                // For(typeof(IRepository<>)).use(typeof(baserepository<>));
            }


                #endregion
      
        

    
}
}