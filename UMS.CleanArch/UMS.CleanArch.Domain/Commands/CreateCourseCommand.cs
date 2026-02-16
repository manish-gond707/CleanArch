using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string desciption, string imageUrl)
        {
            Name = name;
            Description = desciption;
            ImageUrl = imageUrl;
        }
    }
}
