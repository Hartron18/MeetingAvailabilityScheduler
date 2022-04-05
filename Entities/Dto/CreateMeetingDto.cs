using System;

namespace MeetingAvailabilityScheduler.Entities.Models
{
    public class CreateMeeting
    {
        public Guid MeetingId { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
