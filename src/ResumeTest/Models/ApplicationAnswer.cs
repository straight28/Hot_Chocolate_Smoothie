using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeTest.Models
{
    public class ApplicationAnswer
    {
        public int ApplicationId { get; set; }

        public int ResumeQuestionId { get; set; }

        public virtual ResumeQuestion ResumeQuestion { get; set; }

        public string Contents { get; set; }

    }
}
