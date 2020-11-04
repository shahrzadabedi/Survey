using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survey.Domain;

namespace Survey.Business
{
    public interface IUnitOfWork

    {

        // IRepository<TSurvey> Surveys<TSurvey>() where TSurvey : ISurvey;
        object Surveys {get; }
            //where TSurvey : ISurvey;
        void Commit();
    }
}
