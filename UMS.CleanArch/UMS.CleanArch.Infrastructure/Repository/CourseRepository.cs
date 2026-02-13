using UMS.CleanArch.Domain.Interfaces;
using UMS.CleanArch.Domain.Models;
using UMS.CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _context;
        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
           return await _context.Courses.AsNoTracking().ToListAsync();
        }
    }
}
