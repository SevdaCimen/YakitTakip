using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Repository;
using Core.Entitys;
using Service.Service;

namespace Web.Controllers
{
    public class FtsPersonController : Controller
    {

        readonly FtsPersonService ftsPersonService;


        readonly GenericRepository<ftsPerson> genericService;
        public FtsPersonController()
        {
            ftsPersonService = new FtsPersonService();
            genericService = new GenericRepository<ftsPerson>();
        }

        public FtsPersonService FtsPersonService => ftsPersonService;

        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult TumPersonelleriGetir()
        {
            var result = ftsPersonService.TumPersonelleriGetir();
            return Json(new { data = result });
        }
        public IActionResult PersonelSayisi()
        {
            var result = genericService.Query("Select count(*) Id from FtsPerson");
            return Json(result);
        }
        public IActionResult PersonellerveGorevler()
        {
            var result = genericService.Query("select FtsPerson.Ad ,FtsPerson.Soyad,FtsTasks.VehicleId, FtsTasks.TaskDefinition,FtsTasks.TaskDate from FtsTasks ,FtsPerson where FtsTasks.PersonId=FtsPerson.PersonId");
            return Json(new { data = result });
        }


        public IActionResult GorevliOnPersonel()
        {

            var result = genericService.Query("select top(10) FtsPerson.Ad, count(*) as TaskCount from FtsPerson , FtsTasks where FtsPerson.PersonId = FtsTasks.PersonId  group by FtsPerson.Ad order by TaskCount desc");
            return Json(new { data = result });
        }


    }
}