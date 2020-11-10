﻿using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
    public interface ISurveyAgentDAO
    {
        GetSurveysByStatusResponse GetAllSurveys(SurveyStatus Status);
        void Add(SurveyDTO dto);
    }
}
