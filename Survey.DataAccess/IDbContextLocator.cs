using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{   
    public interface ISave 
    {
        void Save();

    }
    public interface IEFRepositoryLocator<TSurvey, TSurveyQAnswer,TQuestion>  :ISave
 
    {
        IRepository<TSurvey> SurveyRep() ;
        IRepository<TSurveyQAnswer> SurveyQAnswerRep { get;  }
        IRepository<TQuestion> QuestionRep();
        

    }
    
}
