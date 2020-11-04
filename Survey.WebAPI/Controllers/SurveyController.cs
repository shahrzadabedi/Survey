using Survey.Business;
using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Survey.WebAPI.Controllers
{
    public class SurveyController : ApiController
    {
        private ISurveyService surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            this.surveyService = surveyService;

        }
        // POST: api/Survey/GetAll
        [HttpPost]
        public GetSurveysByStatusResponse GetAll(GetSurveysByStatusRequest request)
        {
            //var surveys = new List<Domain.Survey>();
            //var vo = new List<ValidOperation>();
            //vo.Add(ValidOperation.Start);

            //surveys.Add(new Domain.Survey() { State = (int)request.Status, Id = 1 , CreateDateTime= DateTime.Now, Duration = 1000, CreatorUserName="sh.abedi" , QCount = 1, Q1="آیا" , ValidOperations = vo});
            return surveyService.GetAll(request);
            
                //Surveys = surveys };
        }

        // GET: api/Survey/5
        public string Get(int id)
        {
            return "value";
        }
              
        // PUT: api/Survey/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Survey/5
        public void Delete(int id)
        {
        }
    }
}
