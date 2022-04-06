using System;

namespace MeetingAvailabilityScheduler.Entities
{
    public class Meeting
    {
        public Guid MeetingId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Owner { get; set; }
    }
}
