using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public class AnswerDTO : IAnswer
    {
        public int Id { get  ; set  ; }
        public short Value { get  ; set  ; }
    }
}
