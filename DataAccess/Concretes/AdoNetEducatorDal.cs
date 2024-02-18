using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetEducatorDal
    {
        public void Add(Educator educator)
        {
            Console.WriteLine(educator.FirstName + " " + educator.LastName + " isimli educator AdoNet kullanılarak veritabanına eklendi.");
        }
    }
}
  