﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.WebAPI.Models
{
    public class GetSurveysByStatusResponse
    {
        public List<SurveyModel> Surveys { get; set; } 
    }
}
