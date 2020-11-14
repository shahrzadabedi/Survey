using Survey.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Ef.DB
{
    public class UserAnswer: IUserAnswer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }              
      
        public Survey Survey { get; set; }
        public int AnswerStatus { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CompleteDateTime { get; set; }
        public DateTime UserLastAnswerDateTime { get; set; }
        public string UserName { get; set; }
        ICollection<Answer> Answers { get; set; }

        

    }
}
