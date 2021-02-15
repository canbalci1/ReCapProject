using Business.Abstract;
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

        public void Add(CarColor color)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarColor color)
        {
            throw new NotImplementedException();
        }

        public List<CarColor> GetAll()
        {
            return _colorDal.GetAll();
        }

        public CarColor GetByColor(int brandColor)
        {
            return _colorDal.Get(c => c.ColorId == brandColor);
        }

        public void Update(CarColor color)
        {
            throw new NotImplementedException();
        }
    }
}
