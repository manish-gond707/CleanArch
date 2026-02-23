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
using MediatR;
using UMS.CleanArch.Domain.Commands;
using UMS.CleanArch.Domain.CommandHandlers;
using UMS.CleanArch.Infra.Data.Context;
using UMS.CleanArch.Domain.Core.Bus;
using UMS.CleanArch.Infra.Bus;

namespace UMS.CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            // Domain InMemoryBus MediatR
            services.AddScoped<ImediatorHandler, InMemoryBus>();

            // Domain Hanlders
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourceService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();

            return services;
        }
    }
}
