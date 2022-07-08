using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HabbitzDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("PoultryGuideConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IBirdCategoryRepository, BirdCategoryRepository>();
        }
    }
}
