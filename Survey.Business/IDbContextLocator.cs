using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
   //public interface IEFRepositoryLocator: IDbContextLocator ,IEFRepositoryLocator
   // {       
       
   // }
    public interface IDbContextLocator 
    {
        DbContext DbContext { get; }

    }
    public interface IEFRepositoryLocator<TSurvey,TUserSurvey> where TSurvey: ISurvey 
        //where TUserSurvey:IUserSurvey
    {
        IRepository<TSurvey> SurveyRep();
        IRepository<TUserSurvey> UserSurveyRep { get;  }

    }
}
