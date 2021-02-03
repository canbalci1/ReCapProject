using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CarBrand:IEntity
    {

        public int BrandId { get; set; }
        public string Brand { get; set; }
    }
}
