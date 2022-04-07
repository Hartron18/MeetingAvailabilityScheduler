using MeetingAvailabilityScheduler.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MeetingAvailabilityScheduler.Contracts
{
    public interface IMeetingRepository
    {
        IQueryable<Meeting> FindByCondition(Expression<Func<Meeting, bool>> expression, bool trackChanges);
        Task<Meeting> GetMeetingsByDateAsync(DateTime start, DateTime end, bool trackChanges);
        Task<Meeting> GetAvailableSlotsByDateAsync(DateTime start, DateTime end, bool trackChanges);
        void CreateMeeting(Meeting meeting);
        void DeleteMeeting(Meeting meeting);

        Task SaveAsync();
    }
}
