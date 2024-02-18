using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CountyManager
    {
        AdoNetCountyDal countyDal = new AdoNetCountyDal();

        public void Add(County county)
        {
            Console.WriteLine("County için iş kuralları çalıştı.");
            countyDal.Add(county);
        }
    }
}
