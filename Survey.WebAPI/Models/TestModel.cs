using Survey.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Survey.WebAPI.Models
{
    public class TestModel
    {
        [Required(ErrorMessage = "AAA")]
        [Range(minimum: 1, maximum: 8)]
        public SurveyStatus SurveyStatus { get; set; }
    }
}