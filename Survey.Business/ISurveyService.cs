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
        Task<List<SurveyResultDto>> GetAllSurveys(SurveyStatus request);
        Task<SurveyResultDto> Get(int Id);
        Task Add(Domain.Survey dto);
    }
}
