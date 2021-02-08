using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(CarBrand entity)
        {
            using (CarsContex context = new CarsContex())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CarBrand entity)
        {
            using (CarsContex context = new CarsContex())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CarBrand Get(Expression<Func<CarBrand, bool>> filter)
        {
            using (CarsContex context = new CarsContex())
            {
                return context.Set<CarBrand>().SingleOrDefault(filter);
            }
        }

        public List<CarBrand> GetAll(Expression<Func<CarBrand, bool>> filter = null)
        {
            using (CarsContex context = new CarsContex())
            {
                return filter == null ? context.Set<CarBrand>().ToList() :
              context.Set<CarBrand>().Where(filter).ToList();
            }
        }

        public void Update(CarBrand entity)
        {
            using (CarsContex context = new CarsContex())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
