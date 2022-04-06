using MeetingAvailabilityScheduler.Contracts;
using MeetingAvailabilityScheduler.LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MeetingAvailabilityScheduler.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureLogger(this IServiceCollection services) => services.AddScoped<ILoggerManager, LoggerManager>();
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseInMemoryDatabase("Meeting");
            });
        }

    }
}
