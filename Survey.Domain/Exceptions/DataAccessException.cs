using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain.Exceptions
{
    public class DataAccessException : Exception
    {
        private string EntityName;
        public DataAccessException(string EntityName )  {
            this.EntityName = EntityName;
        }
    }
}
