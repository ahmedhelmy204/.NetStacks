using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Core.Domain.Questions
{
    public class Question : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
