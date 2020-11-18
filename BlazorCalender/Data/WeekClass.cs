using System.Collections.Generic;

namespace BlazorCalender.Data
{
    public class WeekClass
    {
        public List<DayEvent> Dates { get; set; } = new List<DayEvent>();
    }
}
