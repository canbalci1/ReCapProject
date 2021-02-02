using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CarColor:IEntity
    {
        public int Id { get; set; }
        public string Color { get; set; }
    }
}
