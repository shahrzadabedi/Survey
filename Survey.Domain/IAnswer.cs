using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Domain
{
    public interface IAnswer
    {
        int Id { get; set; }

        short Value { set; get; }
    }
}
