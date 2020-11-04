using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
   public interface IDbContextLocator
    {
        DbContext Get();
    }
}
