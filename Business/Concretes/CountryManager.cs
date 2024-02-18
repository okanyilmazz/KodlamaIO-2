using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CountryManager
    {
        AdoNetCountryDal countryDal = new AdoNetCountryDal();

        public void Add(Country country)
        {
            Console.WriteLine("Country için iş kuralları çalıştı.");
            countryDal.Add(country);
        }

    }
}
