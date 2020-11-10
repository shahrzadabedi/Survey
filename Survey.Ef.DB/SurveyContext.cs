using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Ef.DB
{    
    public class SurveyContext : DbContext
    {
       public SurveyContext() : base()
        {

        }
        public SurveyContext(string s) : base(s) { }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyQAnswer> SurveyQAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SurveyAnswerHistory> SurveyAnswers { get; set; }
    }
}
