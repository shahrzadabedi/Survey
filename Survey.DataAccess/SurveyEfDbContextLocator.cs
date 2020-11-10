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
    public class SurveyEfDbContextLocator : IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.SurveyQAnswer,Ef.DB.Question>
    {

        private DbContext _dbContext;
        private IRepository<Ef.DB.Survey> _surveyRep;
        private IRepository<Ef.DB.SurveyQAnswer> _surveyQAnswer;
        private IRepository<Ef.DB.Question> _question;
       




        public SurveyEfDbContextLocator()
        {
            _dbContext = new SurveyContext("name=SurveyConnection");
            this._surveyRep = new BaseEFRepository<Ef.DB.Survey>(_dbContext);
            this._surveyQAnswer = new BaseEFRepository<Ef.DB.SurveyQAnswer>(_dbContext);


        }


        public IRepository<Ef.DB.Survey> SurveyRep()
        {
            return _surveyRep;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public IRepository<Ef.DB.SurveyQAnswer> SurveyQAnswerRep => throw new NotImplementedException();
        public IRepository<Ef.DB.Question> QuestionRep() { return _question; }
    }
}
