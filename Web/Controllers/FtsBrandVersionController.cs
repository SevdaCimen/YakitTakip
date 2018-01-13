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
    public class FtsBrandVersionController : Controller
    {

        readonly GenericRepository<ftsBranVersion> genericService;
        readonly FtsBrandVersionService _ftsbrandversionService;
        public FtsBrandVersionController()
        {
            genericService = new GenericRepository<ftsBranVersion>();
            _ftsbrandversionService = new FtsBrandVersionService();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MarkaVersiyonListesi()
        {
            var result = genericService.Query("Select  BrandId, Brand.Name  ,Year, AvarageConsumption,HourlyConsumption,FuelTankCapacity,CreatedBy from BrandVersion,Brand where Brand.Id=BrandVersion.BrandId");
            return Json(new { data = result });
        }
        public IActionResult VersiyonTuketim()
        {
            var result = genericService.Query("Select top(6) Brand.Name, AvarageConsumption, HourlyConsumption from BrandVersion, Brand  where Brand.Id = BrandVersion.BrandId");
            return Json(result);
        }
    }
}