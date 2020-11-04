using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class GetSurveysByStatusRequest
    {
        public SurveyStatus Status { get; set; }
        public User User { get; set; }
        
    }
}
