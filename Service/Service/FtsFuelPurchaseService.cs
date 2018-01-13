using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class FtsFuelPurchaseService
    {

        readonly GenericRepository<ftsFuelPurchase> _fuelpurchaseRepository;

        public FtsFuelPurchaseService()
        {
            _fuelpurchaseRepository = new GenericRepository<ftsFuelPurchase>();
        }

    }
}
