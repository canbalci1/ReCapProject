using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<CarBrand> GetAll();
        CarBrand GetById(int brandId);
        void Add(CarBrand brand);
        void Update(CarBrand brand);
        void Delete(CarBrand brandr);
    }
}
