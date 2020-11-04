﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class Survey : ISurvey
    {
        public List<ValidOperation> ValidOperations { get; set; }
        public int Id { get; set; }
        public int Duration { get; set; }
        public short? QCount { get; set; }
        public string CreatorUserName { get; set; }    
        public DateTime CreateDateTime { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }
        private int _state ;
        public int State { get { return _state; } set { _state = value;  } }
        public SurveyStatus Status{ get { return (SurveyStatus)State; }  }
    }
}
