using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entitys
{
  public   class ftsFuelPurchase:Base.BaseEntity
    {
        public int Id { get; set; }
        public DateTime TimeOfSale{ get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Liter { get; set; }
        public decimal TotalAmount { get; set; }
        public int FuelTypeId { get; set; }
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
