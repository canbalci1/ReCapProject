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
    public class EfBrandDal : EfEntityRepositoryBase<CarBrand, CarsContex>, IBrandDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsContex context = new CarsContex())
            {
                var result = from c in context.Cars
                             join b in context.CarBrand
                             on c.BrandId equals b.BrandId


                             select new CarDetailDto
                             {

                                 Brand = b.Brand,
                                 BrandId =b.BrandId,
                               
                             };
                return result.ToList();
            }
        }
    }
}