using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;


//sql sorgularının temel olarak crud olan onları repository çinde yazdık
//özel işlemleri ise servis kısmında yazcaz
//bu işlemler repository de belirlenen fonksiyonlrın çagırılması
namespace Service.Service
{
    public class FtsVehicleService
    {      //genericRepository terminolojisi genel repositori tanımı yapmaya yara
        //sınıfımız için bir degişken tanımladdık

        readonly GenericRepository<FtsVehicle> _ftsvehicleRepository;

        //constructor da bu degişken çin hafızada alan oluştıurduk
        public FtsVehicleService()
        {
            _ftsvehicleRepository = new GenericRepository<FtsVehicle>();
        }

        public object TumPersonelleriGetir()
        {
            throw new NotImplementedException();
        }

        public List<FtsVehicle> TumAraclariGetir()
        {
            return _ftsvehicleRepository.GetAll();
        }
     

    }
}
