using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{   
    public interface IDbContextLocator 
    {
        DbContext DbContext { get; }

    }
    public interface IEFRepositoryLocator<TSurvey,TUserSurvey>  
 
    {
        IRepository<TSurvey> SurveyRep() ;
        IRepository<TUserSurvey> UserSurveyRep { get;  }

    }
    
}
