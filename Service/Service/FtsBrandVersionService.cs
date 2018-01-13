using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class FtsBrandVersionService
    {

        readonly GenericRepository<ftsBranVersion> _brandVersionRepository;
        public FtsBrandVersionService()
        {
            _brandVersionRepository = new GenericRepository<ftsBranVersion>();

        }

    }
}
