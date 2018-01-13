using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entitys
{
   public  class ftsBranVersion:Base.BaseEntity
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int BrandId { get; set; }
        public int FuelTypeId { get; set; }
        public decimal  OrtalamaTuketim { get; set; }
        public decimal  HourlyConsumption { get; set; }
        public decimal FuelTankCapacity { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
