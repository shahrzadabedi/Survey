using Survey.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Survey.WebAPI.Models
{
    public class SurveyModel : ISurvey
    {
        
        public int Id { get; set; }
        [Required]
        [Range(10,20)]
        public int Duration { get; set; }
       
        public string CreatorUserName { get; set; }
        [Required]
        public int State { get; set; }
       
        public DateTime CreateDateTime { get; set; }
        [Required]
        public ICollection<QuestionModel> Questions { get; set; }

    }
}