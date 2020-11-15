using Survey.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Survey.WebAPI.Models
{
    public class QuestionModel
    {
      
        public  int Id { get; set; }
        [Required]
        public int QId { get; set; }
        [Required]
        public string QDesc { get; set; }
        
    }
}