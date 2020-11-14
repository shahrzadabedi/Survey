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
    public interface IEFRepositoryLocator<TSurvey, TUserAnswer,TQuestion>  :ISave
        where TSurvey: ISurvey
        where TQuestion: IQuestion
        where TUserAnswer: IUserAnswer
    {
        IRepository<TSurvey> SurveyRep() ;
        IRepository<TUserAnswer> SurveyQAnswerRep();
        IRepository<TQuestion> QuestionRep();
        

    }
    
}
