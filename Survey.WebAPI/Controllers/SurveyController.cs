﻿using Survey.Business;

using Survey.Domain;
using Survey.Domain.Exceptions;
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
    [BasicAuthentication]
    public class SurveyController : BaseController
    {
        private ISurveyService surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            this.surveyService = surveyService;

        }
        // GET: api/Survey/GetAll
        
        [HttpGet]

        public IHttpActionResult GetAll(SurveyStatus status)
        {
           
            GetSurveysByStatusResponse result = null;
            try 
            {
              result = new GetSurveysByStatusResponse() { 
                  Surveys = surveyService.GetAllSurveys(status).Select(p => p.MapObject()).ToList() };                    
            }
            catch(DataAccessException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex) 
            {
                return InternalServerError(ex);
            }
            return Ok(result);
        }

        // GET: api/Survey/5
        public IHttpActionResult Get(int id)
        {
            SurveyModel result = null;
            try
            {
                result= surveyService.Get(id).MapObject();
             
            }
            catch (DataAccessException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            return Ok(result);
        }
              
        // PUT: api/Survey/5
        public void Put(int id, [FromBody]string value)
        {
        }

        public IHttpActionResult Post(Models.SurveyModel survey)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Data");
            try
           {
                var dto = survey.MapObject();
                dto.CreateDateTime = DateTime.Now;
                surveyService.Add(dto);
            }
            catch (InvalidOperaionException ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Ok();
        }

        // DELETE: api/Survey/5
        public void Delete(int id)
        {
        }
    }
}
