using UMS.CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        Task<CourseViewModel> GetCourses();
    }
}
