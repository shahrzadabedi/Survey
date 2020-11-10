using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Ef.DB
{
    public partial class Survey
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Duration { get; set; }
        //public  Nullable<short> QCount { get; set; }
        public string CreatorUserName { get; set; }
        public int State { get; set; }
        public System.DateTime CreateDateTime { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<SurveyQAnswer> SurveyQAnswers { get; set; }
        public ICollection<SurveyAnswerHistory> SurveyAnswers { get; set; }
    }
}
