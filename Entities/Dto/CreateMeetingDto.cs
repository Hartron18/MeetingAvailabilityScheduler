using System;

namespace MeetingAvailabilityScheduler.Entities.Dto
{
    public class CreateMeetingDto
    {
        public Guid MeetingId { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
