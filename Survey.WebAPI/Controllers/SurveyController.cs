using Survey.Business;
using Survey.Domain;
using Survey.WebAPI.Filters;
using Survey.WebAPI.Models;
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
        // GET: api/Survey/GetAll
        [BasicAuthentication]
        [HttpGet]

        public IHttpActionResult GetAll(SurveyStatus status)
        {
            if (!ModelState.IsValid)
                return BadRequest("ASDASDASD");

            return Ok(surveyService.GetAll(status));
            
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
