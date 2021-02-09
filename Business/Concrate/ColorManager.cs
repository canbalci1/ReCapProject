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

        public List<CarColor> GetAll()
        {
            return _colorDal.GetAll();
        }

        public CarColor GetByColor(int brandColor)
        {
            return _colorDal.Get(c => c.ColorId == brandColor);
        }
    }
}
