using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entitys;
using Microsoft.AspNetCore.Mvc;
using Service.Repository;
using Service.Service;

namespace Web.Controllers
{
    public class FtsBrandController : Controller
    {
        readonly FtsBrandService ftsBrandservice;
        readonly GenericRepository<ftsBrand> genericService;
        public IActionResult Index()
        {
            return View();
        }
        public FtsBrandController()
        {
            ftsBrandservice = new FtsBrandService();
            genericService = new GenericRepository<ftsBrand>();
        }
        public IActionResult ModelTipleri()
        {
            var result = genericService.Query("select count  (Name) as BrandCount,Name from Brand group by Name");
            return Json(new { data = result });
        }

      public IActionResult MarkaAdet()
        {
            var result = genericService.Query("select Name, count  (Name) as BrandCount from Brand group by Name");
            return Json(new { data = result });
        }
    }
}