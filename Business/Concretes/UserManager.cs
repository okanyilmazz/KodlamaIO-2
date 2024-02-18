using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes;

public class UserManager
{
    AdoNetUserDal userDal = new AdoNetUserDal();

    public void Add(User user)
    {
        Console.WriteLine("User için iş kuralları çalıştı.");
        userDal.Add(user);
    }
}
