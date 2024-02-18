using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class StudentManager
    {
        AdoNetStudentDal studentDal = new AdoNetStudentDal();

        public void Add(Student student)
        {
            Console.WriteLine("Student için iş kuralları çalıştı.");
            studentDal.Add(student);
        }
    }
}
