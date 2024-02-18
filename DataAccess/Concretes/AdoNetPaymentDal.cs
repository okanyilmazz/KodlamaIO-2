using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetPaymentDal
    {
        public void Add(Payment payment)
        {
            Console.WriteLine(payment.CardNumber + " numaralı kart AdoNet kullanılarak veritabanına eklendi.");
        }
    }
}
