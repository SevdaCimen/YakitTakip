using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
   public  class FtsPersonService
    {

        readonly GenericRepository<ftsPerson> _ftspersonRepository;

        //constructor da bu degişken çin hafızada alan oluştıurduk
        public FtsPersonService()
        {
            _ftspersonRepository = new GenericRepository<ftsPerson>();
        }

        public List<ftsPerson> TumPersonelleriGetir()
        {
            return _ftspersonRepository.GetAll();
        }

    }
}
