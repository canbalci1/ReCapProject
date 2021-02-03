using Business.Concrate;
using DataAccess.Concrate.InMemory;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            

        }
    }
}
