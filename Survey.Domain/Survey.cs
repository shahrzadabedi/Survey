using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class Survey 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Duration { get; set; }
        public string CreatorUserName { get; set; }
        public SurveyStatus Status { get; set; }
//        public SurveyStatus Status { get { return (SurveyStatus)State; } }

        public System.DateTime CreateDateTime { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }

    }
}
