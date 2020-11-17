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
        Task Save();

    }
    public interface IEFRepositoryLocator<TSurvey, TUserAnswer,TQuestion, TAnswer>  :ISave
        
    {
        IRepository<TSurvey> SurveyRep() ;
        IRepository<TUserAnswer> UserAnswerRep();
        IRepository<TQuestion> QuestionRep();
        IRepository<TAnswer> AnswersRep();
        

    }
    
}
