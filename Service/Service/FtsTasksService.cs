using Core.Entitys;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class FtsTasksService
    {
        readonly GenericRepository<ftsTasks> ftsTasksService;
        public FtsTasksService()
        {
            ftsTasksService = new GenericRepository<ftsTasks>();
        }
         
        public List <ftsTasks> GorevleriGetir()
        {

            return ftsTasksService.GetAll();

        }
    }
}
