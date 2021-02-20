using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //CarTestFirst();
            AddingTest(userManager, customerManager, rentalManager);
            //BrandTestFirst();

        }

        private static void AddingTest(UserManager userManager, CustomerManager customerManager, RentalManager rentalManager)
        {
            userManager.Add(new User { Id = 1, FirstName = "Mert", LastName = "Çakır", Email = "mertckrrr@gmail.com", Password = "123456" });

            customerManager.Add(new Customer { Id = 1, UserId = 1, CompanyName = "CKR Ltd" });

            rentalManager.Add(new Rental { Id = 1, CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 02, 20), ReturnDate = new DateTime(2021, 01, 10) });

            
        }

        private static void BrandTestFirst()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "volvo" });
            //brandManager.Delete( new Brand { BrandId=1002});
        }

        private static void CarTestFirst()
        {
            CarManager carManager = new CarManager(new EfCarDal());


           carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 200, ModelYear = 2018, Description = "Otomatik Dizel" });

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
      
     
    }
}
