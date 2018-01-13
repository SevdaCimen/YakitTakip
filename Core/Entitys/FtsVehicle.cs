using System;

namespace Core.Entitys
{
    public class FtsVehicle:Base.BaseEntity
    {
        public int PersonId { get; set; }
        public int BrandVersionId { get; set; }
        public string LicensePlate { get; set; }
        public int? OwnershipType { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
