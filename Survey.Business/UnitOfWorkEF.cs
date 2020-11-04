using Survey;
using Survey.DataAccess;
using Survey.Domain;
using System.Collections.Generic;
using System.Data.Entity;

namespace Survey.Business
{
    public class UnitOfWorkEF : IUnitOfWork
      
    {

        private IDbContextLocator _dbContextLocator;
        private BaseEFRepository<DataAccess.Survey> _surveys;
        private DbContext _dbContext;
        //private BaseRepository<Order> _orders;

        public UnitOfWorkEF(IDbContextLocator dbContextLocator)
        {
            _dbContextLocator = dbContextLocator;
            _dbContext = _dbContextLocator.Get();
        }


        //public IRepository<DataAccess.Survey> Surveys
        //{
        //    get
        //    {
        //        return _surveys ??
        //               (_surveys = new BaseEFRepository<DataAccess.Survey>(_dbContext));
        //    }
        //}

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        object IUnitOfWork.Surveys
        {
            get
            {
                return _surveys ??
                          (_surveys = new BaseEFRepository<Survey.DataAccess.Survey>(_dbContext));
            }
        }
    }
}
