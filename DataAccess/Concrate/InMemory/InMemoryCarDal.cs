using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
              new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=50000,Description="2.El",ModelYear=2008 },
              new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=60000,Description="2.El",ModelYear=2009 },
              new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=70000,Description="2.El",ModelYear=2010 },
              new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=80000,Description="2.El",ModelYear=2011 },



            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(c => c.Id == car.Id );
            _car.Remove(carDelete);
        }

      

        public List<Car> GetAll()
        {
            return _car;
        }

        public List <Car> GetById(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

       

        public void Update(Car car)
        {
            Car carUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
