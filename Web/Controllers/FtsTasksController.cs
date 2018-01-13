using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Service;
using Service.Repository;
using Core.Entitys;

namespace Web.Controllers
{
    public class FtsTasksController : Controller
    {

        readonly FtsTasksService ftsTasksService;
        readonly GenericRepository<ftsTasks> genericService;
        public FtsTasksController()
        {
            ftsTasksService = new FtsTasksService();
            genericService = new GenericRepository<ftsTasks>();
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TumGorevleriGetir()
        {
            var result = ftsTasksService.GorevleriGetir();
            return Json(new { data = result });
        }

        public IActionResult GorevTipleri()
        {
            var result = genericService.Query("select count(TaskDefinition) as TaskCount,TaskDefinition from FtsTasks group by TaskDefinition");
            return Json (new { data = result });
        }
        public IActionResult GorevSayisi()
        {
            var result = genericService.Query("SELECT COUNT(Id) as TaskCount FROM FtsTasks");
            return Json(result);
        }
    }
}