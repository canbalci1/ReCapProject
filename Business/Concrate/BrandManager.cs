using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(CarBrand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarBrand brandr)
        {
            throw new NotImplementedException();
        }

        public List<CarBrand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public CarBrand GetById(int brandId)
        {
            return _brandDal.Get(c => c.BrandId == brandId);
        }

        public void Update(CarBrand brand)
        {
            throw new NotImplementedException();
        }
    }
}
