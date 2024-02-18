using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PaymentManager
    {
        AdoNetPaymentDal paymentDal = new AdoNetPaymentDal();

        public void Add(Payment payment)
        {
            Console.WriteLine("Payment için iş kuralları çalıştı.");
            paymentDal.Add(payment);
        }
    }
}
