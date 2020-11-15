using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
    public interface ISurveyService
    {
        List<SurveyResultDto> GetAllSurveys(SurveyStatus request);
        SurveyResultDto Get(int Id);
        void Add(Domain.Survey dto);
    }
}
