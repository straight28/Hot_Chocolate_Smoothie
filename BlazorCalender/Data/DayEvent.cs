using System;

namespace BlazorCalender.Data
{
    public class DayEvent
    {
        public int DayEventId { get; set; }
        public string Note { get; set; }

        public DateTime EventDate { get; set; } = DateTime.MinValue;

        public DateTime FromDate { get; set; } = DateTime.MinValue;

        public DateTime ToDate { get; set; } = DateTime.MinValue;

        public string DateValue { get; set; }

        public string DayName { get; set; }
        public string Message { get; set; }



    }
}
