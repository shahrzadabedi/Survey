﻿using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business
{
    public interface ISurveyService
    {
        GetSurveysByStatusResponse GetAll(GetSurveysByStatusRequest request);
    }
}
