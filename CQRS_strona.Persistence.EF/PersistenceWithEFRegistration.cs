

using CQRS_strona.Application;
using CQRS_strona.Application.Contract.Persistance;
using CQRS_strona.Application.Contracts.Persistance;
using CQRS_strona.Persistence.EF.Repositories;
 using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS_strona.Persistence.EF
{
    public static class PersistenceWithEFRegistration
    {
        public static IServiceCollection AddEduZbieraczPersistenceEFServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CQRS_stronaContext>(options =>
                options.UseSqlServer(configuration.
                GetConnectionString("CQRS_stronaConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IWebinaryRepository, WebinaryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }
    }
}
