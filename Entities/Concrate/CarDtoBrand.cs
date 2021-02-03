using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CarDtoBrand:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Brand { get; set; }
        public int ColorId { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
