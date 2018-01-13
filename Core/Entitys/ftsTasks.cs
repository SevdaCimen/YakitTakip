using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entitys
{
    public class ftsTasks:Base.BaseEntity
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int PersonId { get; set; }
        public string TaskDefinition { get; set; }
        public DateTime TaskDate { get; set; }
    }
}
