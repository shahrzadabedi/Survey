using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain

{
   public interface ISurvey
    {
         int Id { get; set; }
         int Duration { get; set; }
       
         string CreatorUserName { get; set; }
         int State { get; set; }
         System.DateTime CreateDateTime { get; set; }
     
        

    }
}
