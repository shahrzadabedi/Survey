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
    public class SurveyEfDbContextLocator : IEFRepositoryLocator<Ef.DB.Survey, Ef.DB.UserAnswer,Ef.DB.Question,Ef.DB.Answer>
    {

        private DbContext _dbContext;
        private IRepository<Ef.DB.Survey> _surveyRep;
        private IRepository<Ef.DB.UserAnswer> _userAnswer;
        private IRepository<Ef.DB.Question> _question;
        private IRepository<Ef.DB.Answer> _answer;




        public SurveyEfDbContextLocator()
        {
            _dbContext = new SurveyContext();
            this._surveyRep = new BaseEFRepository<Ef.DB.Survey>(_dbContext);
            this._userAnswer = new BaseEFRepository<Ef.DB.UserAnswer>(_dbContext);


        }


        public IRepository<Ef.DB.Survey> SurveyRep()
        {
            return _surveyRep;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public IRepository<Ef.DB.UserAnswer> UserAnswerRep() { return _userAnswer; }
        public IRepository<Ef.DB.Question> QuestionRep() { return _question; }

        public IRepository<Answer> AnswersRep()  { return _answer;   }
    }
}
