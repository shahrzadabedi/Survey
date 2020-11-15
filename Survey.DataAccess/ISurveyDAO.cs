using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    public interface ISurveyAgentDAO
    {
        List<Domain.Survey> GetAllSurveys(SurveyStatus Status);
        void Add(Domain.Survey dto);
    }
}
