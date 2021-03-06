﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCutingConcerns.Validation;
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
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(CarBrand brand)
        {
            
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Delete(CarBrand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List <CarBrand>> GetAll()
        {
            //if (DateTime.Now.Hour == 6)
            //{
            //    return new ErrorDataResult<List<CarBrand>>(Messages.MaintinanceTime);
            //}



            return new SuccessDataResult<List<CarBrand>>(_brandDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult <CarBrand> GetById(int brandId)
        {
            return new SuccessDataResult<CarBrand>(_brandDal.Get(c => c.BrandId == brandId));
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(CarBrand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
