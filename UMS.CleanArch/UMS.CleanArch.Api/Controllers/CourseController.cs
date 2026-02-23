using Microsoft.AspNetCore.Mvc;
using UMS.CleanArch.Application.Interfaces;
using UMS.CleanArch.Application.ViewModels;
using UMS.CleanArch.Domain.Interfaces;

namespace UMS.CleanArch.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CourseViewModel courseViewModel)
        {
            await _courseService.Create(courseViewModel);
            return Ok(courseViewModel);
        }
    }
}
