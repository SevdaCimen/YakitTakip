using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entitys
{
   public  class ftsBrand:Base.BaseEntity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
    }
}
