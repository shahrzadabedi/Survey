﻿using Survey.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Ef.DB
{
   public class Question : IQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Survey Survey { get; set; }
        public ICollection<Answer> Answers { get; set; }        
        public int QId { get; set; }
        public string QDesc { get; set; }
    }
}
