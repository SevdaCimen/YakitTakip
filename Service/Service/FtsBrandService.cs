using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{

    

    public class FtsBrandService
    {
        readonly GenericRepository<ftsBrand> _brandRepository;

        public FtsBrandService()
        {
            _brandRepository = new GenericRepository<ftsBrand>();
         }
    }
}
