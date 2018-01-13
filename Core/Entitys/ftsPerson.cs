using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entitys
{
   public  class ftsPerson:Base.BaseEntity
    {
        public int PersonId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long? Tc { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
