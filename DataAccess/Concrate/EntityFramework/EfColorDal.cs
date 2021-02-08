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
    public class EfColorDal : IColorDal
    {
        public void Add(CarColor entity)
        {
            using (CarsContex context = new CarsContex())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CarColor entity)
        {
            using (CarsContex context = new CarsContex())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            using (CarsContex context = new CarsContex())
            {
                return context.Set<CarColor>().SingleOrDefault(filter);
            }
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            using (CarsContex context = new CarsContex())
            {
                return filter == null ? context.Set<CarColor>().ToList() :
              context.Set<CarColor>().Where(filter).ToList();
            }
        }

        public void Update(CarColor entity)
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
