using Survey.Ef.DB;
using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
    public class SurveyEfDbContextLocator : IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.User_Survey>,IDbContextLocator
    {
        
        private readonly DbContext _dbContext;
        private IRepository<Ef.DB.Survey> _surveyRep;
        private IRepository<Ef.DB.User_Survey> _user_survey;
        public DbContext DbContext { get { return _dbContext; }  }




        public SurveyEfDbContextLocator()
        {
            _dbContext = new SurveyEntities();
            this._surveyRep = new BaseEFRepository<Ef.DB.Survey>(_dbContext);
            this._user_survey = new BaseEFRepository<Ef.DB.User_Survey>(_dbContext);
            
            
        }
             

        public IRepository<Ef.DB.Survey> SurveyRep()
        {
            return _surveyRep;
        }
        public IRepository<User_Survey> UserSurveyRep => throw new NotImplementedException();
    }
}
