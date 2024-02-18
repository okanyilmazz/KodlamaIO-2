using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetCourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine(course.CourseName + " isimli kurs AdoNet kullanılarak veritabanına eklendi.");
        }
    }
}
