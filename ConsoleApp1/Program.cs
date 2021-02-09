using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brand();
            //Color();
            Car();

        }

        private static void Car()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.Brand + " " + car.Color +" "+ car.DailyPrice);
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
