using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class efCarDal : ICarDal
    {
        List<Car> _car;
        List<CarBrand> _brands;
        List<CarColor> _color;
        public efCarDal()
        {
            _car = new List<Car> {
              new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=50000,Description="2.El",ModelYear=2008 },
              new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=60000,Description="2.El",ModelYear=2009 },
              new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=70000,Description="2.El",ModelYear=2010 },
              new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=80000,Description="2.El",ModelYear=2011 },



            };

            _brands = new List<CarBrand> {
            new CarBrand {BrandId =1 ,Brand="Volkswagen"},
            new CarBrand {BrandId =2 ,Brand="Audi"},

            };
            _color = new List<CarColor>
            {
                new CarColor {ColorId=1,Color="White"},
                new CarColor {ColorId=2 , Color="Black"},
            };

            var result = from c in _car
                         join b in _brands
                         on c.BrandId equals b.BrandId
                         join col in _color
                         on c.ColorId equals col.ColorId


                         select new CarList
                         {
                             Id = c.Id,
                             BrandId = c.BrandId,
                             ColorId = c.ColorId,
                             DailyPrice = c.DailyPrice,
                             Description = c.Description,
                             ModelYear = c.ModelYear
                         };

            foreach (var carDto in result)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", carDto.Id, carDto.ColorId, carDto.BrandId, carDto.DailyPrice,
                    carDto.Description, carDto.ModelYear);
            }




        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
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
