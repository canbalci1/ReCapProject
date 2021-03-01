﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(CarBrand brand)
        {
            if (brand.BrandId > 0 && brand.BrandId <= 3 )
            {
                _brandDal.Add(brand);

                return new SuccessResult(Messages.BrandAdded);
            }
            return new ErrorResult(Messages.CarIdInvalid);
        }

        public IResult Delete(CarBrand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List <CarBrand>> GetAll()
        {
            if (DateTime.Now.Hour == 6)
            {
                return new ErrorDataResult<List<CarBrand>>(Messages.MaintinanceTime);
            }

            return new SuccessDataResult<List<CarBrand>>(_brandDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult <CarBrand> GetById(int brandId)
        {
            return new SuccessDataResult<CarBrand>(_brandDal.Get(c => c.BrandId == brandId));
        }

        public IResult Update(CarBrand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
