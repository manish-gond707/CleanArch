using UMS.CleanArch.Application.Interfaces;
using UMS.CleanArch.Application.ViewModels;
using UMS.CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Core.Bus;
using System.Runtime.InteropServices;
using UMS.CleanArch.Domain.Commands;

namespace UMS.CleanArch.Application.Services
{
    public class CourceService : ICourseService
    {
        private ICourseRepository _courseRepository;
        private ImediatorHandler _bus;
        public CourceService(ICourseRepository courseRepository, ImediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public async Task Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
           );
            await _bus.SendCommand(createCourseCommand);
        }

        public async Task<CourseViewModel> GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = await _courseRepository.GetCourses(),
            };
        }
    }
}
