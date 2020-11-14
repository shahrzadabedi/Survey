//using Survey.Ef.DB;
using Survey.Domain;
using Survey.Ef.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    public class SurveyEfDbContextLocator : IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.UserAnswer,Ef.DB.Question>
    {

        private DbContext _dbContext;
        private IRepository<Ef.DB.Survey> _surveyRep;
        private IRepository<Ef.DB.UserAnswer> _surveyQAnswer;
        private IRepository<Ef.DB.Question> _question;
       




        public SurveyEfDbContextLocator()
        {
            _dbContext = new SurveyContext();
            this._surveyRep = new BaseEFRepository<Ef.DB.Survey>(_dbContext);
            this._surveyQAnswer = new BaseEFRepository<Ef.DB.UserAnswer>(_dbContext);


        }


        public IRepository<Ef.DB.Survey> SurveyRep()
        {
            return _surveyRep;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public IRepository<Ef.DB.UserAnswer> SurveyQAnswerRep() { return _surveyQAnswer; }
        public IRepository<Ef.DB.Question> QuestionRep() { return _question; }
    }
}
