using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetUserDal
    {
        public void Add(User user)
        {
            Console.WriteLine(user.FirstName + " isimli kişi AdoNet kullanılarak veritabanına kaydedildi. ");
        }
    }
}
