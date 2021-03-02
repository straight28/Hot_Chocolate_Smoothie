using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Signal.Model
{
    public class TesterChat
    {
        public int Id { get; set; }

        public int TesterId { get; set; }

        [NotMapped]
        public virtual Tester Tester { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public DateTime CreatedDateTime { get; set; }

    }
}
