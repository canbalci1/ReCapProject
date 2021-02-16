using Business.Concrate;
using Business.Constants;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brand();
            //Color();
            //Car();
            UserAdd();

        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User
            {
                
                FirstName = "Elif",
                LastName = "Çetin",
                Email = "elifcetin@hotmail.com" ,
                Password = "123456"
            };
            userManager.Add(user);
            Console.WriteLine(Messages.UserAdded);
            
            Console.ReadLine();
        }

        private static void Car()
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Brand + " " + car.Color + " " + car.DailyPrice);
                }
               
            }
            else
            {
                Console.WriteLine(result.Message);
            }

          
        }

        private static void Color()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Color);
            }
        }

        private static void Brand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Brand);
            }
        }
    }
}
