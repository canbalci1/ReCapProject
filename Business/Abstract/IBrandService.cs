using Core.Utilities.Results;
using Entities.Concrate;
using System;
using Entities.DTOs;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult< List<CarBrand>> GetAll();
        IDataResult <CarBrand> GetById(int brandId);
        IResult  Add(CarBrand brand);
        IResult  Update(CarBrand brand);
        IResult  Delete(CarBrand brand);
    }
}
