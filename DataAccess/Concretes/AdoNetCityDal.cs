using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetCityDal
    {
        public void Add(City city)
        {
            Console.WriteLine(city.CityName+" isimli şehir AdoNet kullanılarak veritabanına kaydedildi. ");
        }
    }
}
