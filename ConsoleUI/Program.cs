using Business.Concretes;
using Entities.Concretes;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Category ile ilgili kodlar*/

            Category category = new Category();
            category.Id = 1;
            category.Name = "Programlama";

            CategoryManager categoryManager = new CategoryManager();
            //categoryManager.Add(category);

            /* Student ile ilgili kodlar */

            Student student = new Student();
            student.Id = 1;
            student.FirstName = "Okan";
            student.LastName = "YILMAZ";
            student.ImagePath = "okan.jpg";
            student.Email = "okan@okan.com";
            student.Password = "123456";

            StudentManager studentManager = new StudentManager();
            //studentManager.Add(student);

            /*  Course ile ilgili kodlar*/

            Course course = new Course();
            course.Id = 1;
            course.CourseName = "C# + Angular";
            course.CoursePrice = "ÜCRETSİZ";
            course.CourseThumbnail = "course.jpg";
            course.CategoryId = 1;

            CourseManager courseManager = new CourseManager();
            // courseManager.Add(course);

            /* Address ile ilgili kodlar */

            Address address = new Address();
            address.Id = 1;
            address.AddressDescription = "Atatürk bulvarı çilek sokak no 5 daire 8";
            address.CountyId = 1;

            AddressManager addressManager = new AddressManager();
            //addressManager.Add(address);

            /* City ile ilgili kodlar */

            City city = new City();
            city.Id = 1;
            city.CityName = "İstanbul";
            city.CountryId = 1;

            CityManager cityManager = new CityManager();
            //cityManager.Add(city);

            /* Country ile ilgili kodlar */

            Country country = new Country();
            country.Id = 1;
            country.CountryName = "Türkiye";

            CountryManager countryManager = new CountryManager();
            //countryManager.Add(country);

            /* County ile ilgili kodlar */

            County county = new County();
            county.Id = 1;
            county.CountyName = "Beyoğlu";
            county.CityId = 1;

            CountyManager countyManager = new CountyManager();
            //countyManager.Add(county);

            /* Educator ile ilgili kodlar */

            Educator educator = new Educator();
            educator.Id = 1;
            educator.FirstName = "Engin";
            educator.LastName = "Demiroğ";
            educator.Email = "engin@engin.com";
            educator.ImagePath = "engin.jpg";
            educator.Password = "123456";

            EducatorManager educatorManager = new EducatorManager();
            //educatorManager.Add(educator);

            /* Payment ile ilgili kodlar */

            Payment payment = new Payment();
            payment.Id = 1;
            payment.CardNumber = "5689597745789999";
            payment.ExpirationMonth = 12;
            payment.ExpirationYear = 2028;
            payment.Cvc = 659;
            payment.CardName = "Okan YILMAZ";

            PaymentManager paymentManager = new PaymentManager();
            paymentManager.Add(payment);
        }
    }
}