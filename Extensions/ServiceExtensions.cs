using MeetingAvailabilityScheduler.Contracts;
using MeetingAvailabilityScheduler.LoggerService;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MeetingAvailabilityScheduler.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureLogger(this IServiceCollection services) => services.AddScoped<ILoggerManager, LoggerManager>();

    }
}
