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
    public class SurveyEfDbContextLocator : IEFRepositoryLocator<Domain.Survey, Domain.UserAnswer,Domain.Question,Domain.Answer>
    {

        private DbContext _dbContext;
        private IRepository<Domain.Survey> _surveyRep;
        private IRepository<Domain.UserAnswer> _userAnswerRep;
        private IRepository<Domain.Question> _questionRep;
        private IRepository<Domain.Answer> _answerRep;




        public SurveyEfDbContextLocator()
        {
            _dbContext = new SurveyContext();
            this._surveyRep = new BaseEFRepository<Domain.Survey>(_dbContext);
            this._userAnswerRep = new BaseEFRepository<Domain.UserAnswer>(_dbContext);
            this._questionRep = new BaseEFRepository<Domain.Question>(_dbContext);
            this._answerRep = new BaseEFRepository<Domain.Answer>(_dbContext);

        }


        public IRepository<Domain.Survey> SurveyRep()
        {
            return _surveyRep;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public IRepository<Domain.UserAnswer> UserAnswerRep() { return _userAnswerRep; }
        public IRepository<Domain.Question> QuestionRep() { return _questionRep; }

        public IRepository<Domain.Answer> AnswersRep()  { return _answerRep;   }
    }
}
