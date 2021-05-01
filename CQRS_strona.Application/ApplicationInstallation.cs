using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace CQRS_strona.Application
{
    public static class ApplicationInstallation
    {
        public static IServiceCollection AddCQRS_stronaApplication(this IServiceCollection services)
        {
            //szuka klasy MappingProfile i powiedz co jest mapowane na co
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            //szuka IRequest oraz IRequestHandler
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
