using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeTest.Models
{
    public class Application
    {
        
        public int Id { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string Sex { get; set; }
        public string Address { get; set; }






        
    }
}
