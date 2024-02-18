using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CityManager
    {
        AdoNetCityDal cityDal = new AdoNetCityDal();

        public void Add(City city)
        {
            Console.WriteLine("City için iş kuralları çalıştı.");
            cityDal.Add( city );
        }
    }
}
