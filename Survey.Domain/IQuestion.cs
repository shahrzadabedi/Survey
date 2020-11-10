using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
   public interface IQuestion
    {
       
         int Id { get; set; }
         int QId { get; set; }
         string QDesc { get; set; }
    }
}
