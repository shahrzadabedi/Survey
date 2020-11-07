using Survey.DataAccess;
using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
    public class SurveyEfDbContextLocator : IEFRepositoryLocator<DataAccess.Survey,DataAccess.User_Survey>,IDbContextLocator
    {
        
        private readonly DbContext _dbContext;
        private IRepository<DataAccess.Survey> _surveyRep;
        private IRepository<DataAccess.User_Survey> _user_survey;
        public DbContext DbContext { get { return _dbContext; }  }

     

        //public IRepository<TSurvey> SurveyRep { get { return _surveyRep; } }
        //public IRepository<DataAccess.User_Survey> UserSurveyRep { get { return _user_survey; } }


        public SurveyEfDbContextLocator()
        {
            _dbContext = new SurveyEntities();
            _surveyRep = new BaseEFRepository<DataAccess.Survey>(DbContext);
            _user_survey = new BaseEFRepository<DataAccess.User_Survey>(DbContext);
        }
             

        public IRepository<DataAccess.Survey> SurveyRep()
        {
            return _surveyRep;
        }
        public IRepository<User_Survey> UserSurveyRep => throw new NotImplementedException();
    }
}
