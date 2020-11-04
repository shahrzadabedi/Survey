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
      Nullable<short> QCount { get; set; }
      string CreatorUserName { get; set; }
      int State { get; set; }
      System.DateTime CreateDateTime { get; set; }
      string Q1 { get; set; }
      string Q2 { get; set; }
      string Q3 { get; set; }
      string Q4 { get; set; }
      string Q5 { get; set; }
      string Q6 { get; set; }
      string Q7 { get; set; }
      string Q8 { get; set; }
      string Q9 { get; set; }
      string Q10 { get; set; }
    }
}
