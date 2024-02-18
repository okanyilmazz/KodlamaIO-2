using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class EducatorManager
    {
        AdoNetEducatorDal educatorDal = new AdoNetEducatorDal();

        public void Add(Educator educator)
        {
            Console.WriteLine("Educator için iş kuralları çalıştı.");
            educatorDal.Add(educator);
        }
    }
}
