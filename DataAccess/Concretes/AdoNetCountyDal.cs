using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetCountyDal
    {
        public void Add(County county)
        {
            Console.WriteLine(county.CountyName + " isimli ilçe AdoNet kullanılarak veritabanına eklendi");
        }
    }
}
