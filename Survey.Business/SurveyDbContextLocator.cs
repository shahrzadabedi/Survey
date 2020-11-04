using Survey.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
    public class SurveyDbContextLocator : IDbContextLocator
    {
        public DbContext Get()
        {
            return new SurveyEntities();
        }
    }
}
