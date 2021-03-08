using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCutingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(CarColor color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _colorDal.Add(color);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(CarColor color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult< List<CarColor>> GetAll()
        {
            _colorDal.GetAll();
            return new SuccessDataResult<List<CarColor>>(_colorDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult< CarColor> GetByColor(int colorId)
        {
            
            return new SuccessDataResult<CarColor>( _colorDal.Get(c => c.ColorId == colorId));
        }

        public IResult Update(CarColor color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
