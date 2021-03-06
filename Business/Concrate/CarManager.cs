﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCutingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);

        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);

        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==6)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintinanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Car> GetById (int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }

        public IDataResult< List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

       
    }
}
