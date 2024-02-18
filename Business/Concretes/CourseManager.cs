using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager
    {
        AdoNetCourseDal courseDal = new AdoNetCourseDal();
        public void Add(Course course)
        {
            Console.WriteLine("Course için iş kuralları çalıştı.");
            courseDal.Add(course);
        }
    }
}
