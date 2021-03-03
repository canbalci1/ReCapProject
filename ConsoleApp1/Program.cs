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
            Brand();
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
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.Color);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
          
        }

        private static void Brand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + " " + brand.Brand);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
