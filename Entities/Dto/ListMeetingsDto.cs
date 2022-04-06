using System;

namespace MeetingAvailabilityScheduler.Entities.Dto
{
    public class ListMeetingsDto
    {
        public Guid MeetingId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}