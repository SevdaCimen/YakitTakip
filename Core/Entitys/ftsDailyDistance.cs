using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entitys
{
   public  class ftsDailyDistance:Base.BaseEntity
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public decimal MyPTotalDistanceroperty { get; set; }
        public int TotalRunningTime { get; set; }
        public decimal ShiftDistance { get; set; }
        public int ShiftRunningTime { get; set; }
        public DateTime Date { get; set; }
        public string LicensePlate { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}
