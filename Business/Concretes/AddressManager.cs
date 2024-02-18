using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AddressManager
    {
        AdoNetAddressDal addressDal = new AdoNetAddressDal();

        public void Add(Address address)
        {
            Console.WriteLine("Address için iş kuralları çalıştı.");
            addressDal.Add(address);
        }
    }
}
