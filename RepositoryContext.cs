using MeetingAvailabilityScheduler.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingAvailabilityScheduler
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }
        public DbSet<Meeting> Meetings { get; set; }

    }
}
