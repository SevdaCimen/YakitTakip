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
    public class FtsFuelPurchaseController : Controller
    {
        readonly FtsFuelPurchaseService ftsFuelPurchaseService;


        readonly GenericRepository<ftsFuelPurchase> genericService;

        public FtsFuelPurchaseController()
        {
            ftsFuelPurchaseService = new FtsFuelPurchaseService();
            genericService = new GenericRepository<ftsFuelPurchase>();
        }

        public IActionResult Index()
        {
            return View();
        }


        
        public IActionResult AracYakitBilgisi()
        {

            var result = genericService.Query("select VehicleId,LicensePlate,FuelTypeId,UnitPrice,Liter,TotalAmount from FuelPurchase");
            return Json(new { data = result });
        }
      
             public IActionResult AracToplamYakitBilgisi()
        {

            var result = genericService.Query("select VehicleId,LicensePlate,Liter,TotalAmount from FuelPurchase");
            return Json(new { data = result });
        }


        public IActionResult EnCokYakitTuketen()
        {
            var result = genericService.Query("select top(5) VehicleId,TotalAmount from FuelPurchase  order by TotalAmount desc");
            return Json(new { data = result });
        }

       public IActionResult  ToplamYakitLitresi()
        {
            var result = genericService.Query("Select sum(TotalAmount) as TotalFuel from FuelPurchase");
            return Json(result);
        }
    }
}