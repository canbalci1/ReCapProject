using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult< List<CarColor>> GetAll();
        IDataResult<CarColor> GetByColor(int brandColor);
        IResult Add(CarColor color);
        IResult Update(CarColor color);
        IResult Delete(CarColor color);
    }
}
