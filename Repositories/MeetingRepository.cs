using MeetingAvailabilityScheduler.Contracts;
using MeetingAvailabilityScheduler.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MeetingAvailabilityScheduler.Repositories
{
    public class MeetingRepository: IMeetingRepository
    {
        private RepositoryContext _repositoryContext;
        public MeetingRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IQueryable<Meeting> FindByCondition(Expression<Func<Meeting, bool>> expression, bool trackChanges) =>
            !trackChanges ? _repositoryContext.Set<Meeting>()
            .Where(expression)
            .AsNoTracking() : _repositoryContext.Set<Meeting>()
            .Where(expression);

        public async Task<Meeting> GetMeetingsByDateAsync(DateTime start, DateTime end, bool trackChanges) =>
            await FindByCondition(e => e.Start.Equals(start) && e.End.Equals(end), trackChanges)
            .FirstOrDefaultAsync();

        public async Task<Meeting> GetAvailableSlotsByDateAsync(DateTime start, DateTime end, bool trackChanges) =>
            await FindByCondition(e => e.Start.Equals(start) && e.End.Equals(end), trackChanges)
            .FirstOrDefaultAsync();

        public void CreateMeeting(Meeting meeting) => _repositoryContext.Meetings.Add(meeting);
        public void DeleteMeeting(Meeting meeting) => _repositoryContext.Meetings.Remove(meeting);
        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
