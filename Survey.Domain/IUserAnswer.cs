using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public interface IUserAnswer
    {
        int Id { get; set; }

        int AnswerStatus { get; set; }
        DateTime StartDateTime { get; set; }
        DateTime CompleteDateTime { get; set; }
        DateTime UserLastAnswerDateTime { get; set; }
        string UserName { get; set; }
    }
}
