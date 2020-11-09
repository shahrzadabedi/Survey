using Survey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
   public static class SurveyMapper
    {
        public static TSurvey MapObject<TSurvey>(this Domain.ISurvey obj) 
            where TSurvey : ISurvey, new()
        {
            TSurvey result = (TSurvey)(obj);
            return result;
            
        }
        //public static Domain.Survey MapObject() { }
    }
}
