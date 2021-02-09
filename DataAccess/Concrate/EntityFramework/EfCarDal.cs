using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContex>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsContex context = new CarsContex())
            {
                var result = from c in context.Cars
                             join b in context.CarBrand
                             on c.BrandId equals b.BrandId
                             join co in context.CarColor
                             on c.ColorId equals co.ColorId

                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Brand = b.Brand,
                                 Color = co.Color,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
