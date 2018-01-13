using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class FtsDailyDistanceService
    {
        readonly GenericRepository<ftsDailyDistance> _dailydistanceRepository;

        public FtsDailyDistanceService()
        {

            _dailydistanceRepository = new GenericRepository<ftsDailyDistance>();
        }
    }
}
