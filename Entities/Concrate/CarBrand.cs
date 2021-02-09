
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Entities.Concrate
{
    public class CarBrand:IEntity
    {
        [Key]
        public int  BrandId { get; set; }
        public string Brand { get; set; }
    }
}
