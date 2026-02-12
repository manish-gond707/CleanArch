using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourceService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourceService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
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
