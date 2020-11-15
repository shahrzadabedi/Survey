using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class SurveyResultDto
    {
        public Survey Survey { get; set; }
        public List<ValidOperation> ValidOperations { get; set; }
    }
}
