using UMS.CleanArch.Application.Interfaces;
using UMS.CleanArch.Application.Services;
using UMS.CleanArch.Domain.Interfaces;
using UMS.CleanArch.Domain.Models;
using UMS.CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICourseService, CourceService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            return services;
        }
    }
}
