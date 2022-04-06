using MeetingAvailabilityScheduler.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingAvailabilityScheduler
{
    public class RepositoryContext:DbContext
    {
       public DbSet<Meeting> Meetings { get; set; }

    }
}
