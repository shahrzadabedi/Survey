using Survey.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
    //public class DefaultRegistry : StructureMap.Registry
    //{
    //    public DefaultRegistry()
    //    {
    //        Scan(
    //            scan => {
    //                scan.TheCallingAssembly();
    //                scan.WithDefaultConventions();

    //                //This line of code is just directions telling StructureMap 
    //                //where to look for DAL models.  
    //                //Typically, my DAL code lives in different class library
    //                scan.AssemblyContainingType<SurveyEntities>();

    //                //To connect implementations to our open generic type of IRepository, 
    //                //we use the ConnectImplementationsToTypesClosing method.  
    //                scan.ConnectImplementationsToTypesClosing(typeof(IRepository<>));
    //            });
    //        //For<IExample>().Use<Example>();

    //        //Here we resolve object instances of our DbContext and IRepository
    //        For<DbContext>().Use(ctx => new SurveyEntities());
    //        For(typeof(IRepository<>)).Use(typeof(BaseRepository<>));
    //    }
    //}
}
