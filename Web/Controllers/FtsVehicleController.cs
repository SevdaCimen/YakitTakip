using Core.Entitys;
using Microsoft.AspNetCore.Mvc;
using Service.Repository;
using Service.Service;

namespace Web.Controllers
{
    public class FtsVehicleController : Controller
    {
        readonly FtsVehicleService ftsVehicleService;
        readonly GenericRepository<FtsVehicle> genericService;
        public FtsVehicleController()
        {
            ftsVehicleService = new FtsVehicleService();
            genericService = new GenericRepository<FtsVehicle>();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TumAraclariGetir()
        {
            var result = ftsVehicleService.TumAraclariGetir();
            return Json(new { data = result });
        }
        
        public IActionResult AraclaraGoreMesafeler()
        {
            var result = genericService.Query("select top 10 LicensePlate Day,sum(TotalDistance) KiloMetre from DailyDistance  group by LicensePlate order by KiloMetre desc");
            return Json(result);
        }
        public IActionResult AracSayisi()
        {
            var result = genericService.Query("Select count(*) Id from FtsVehicle");
            return Json(result);
        }

        public IActionResult EnCokMesafeKatedenAraclar()
        {
            var result = genericService.Query("select top 5 VehicleId,TotalDistance from DailyDistance order by  TotalDistance desc ");
            return Json(result);

        }
        public IActionResult EnCokMesafeKatedenOnAraclar()
        {
            var result = genericService.Query("select top 10 VehicleId,TotalDistance from DailyDistance order by  TotalDistance desc ");
            return Json(result);

        }
        public IActionResult BirinciAracKm()
        {
            var result = genericService.Query("select  max(TotalDistance) as TotalKm from DailyDistance  ");
            return Json(result);
        }
        public IActionResult BirinciAracId()
        {
            var result = genericService.Query("select  top(1)  VehicleId from DailyDistance   order by TotalDistance  desc");
            return Json(result);
        }
        public IActionResult BirinciAracSaat()
        {
            var result = genericService.Query("select   top(1)CreatedOn from DailyDistance order by  TotalDistance desc ");
            return Json(result);
        }
        public IActionResult AraclarinToplamYakitTuketimi()
        {
            var result = genericService.Query("select top(5) VehicleId,TotalAmount from FuelPurchase order by TotalAmount desc");
                return Json(result);
        }
        public IActionResult ToplamYakıtSaat()
        {
            var result = genericService.Query("select top(1)CreatedOn from FuelPurchase order by TotalAmount desc");
            return Json(result);
        }

        public IActionResult EnCokGorevAlanPersoneller()
        {
            var result = genericService.Query("select top(5) FtsPerson.PersonId ,Ad from FtsTasks ,FtsPerson where FtsTasks.PersonId=FtsPerson.PersonId ");
            return Json(result);

        }

 //SQL PROCEDURE 

//        create proc GetVehicleHistory
//(@VehicleId int)
//as
//begin
//select v.Id,sum(d.TotalDistance) as ToplamMesafe,sum(f.Liter) as ToplamYakit from FtsVehicle v
//join DailyDistance d on v.Id = d.VehicleId
//join FuelPurchase f on v.Id = f.VehicleId
//where v.Id= @VehicleId
// group by v.Id
//end


//exec GetVehicleHistory 3085

        public IActionResult AracGecmisi(int Id)
        {
            var result = genericService.Query("exec GetVehicleHistory "+Id);
            return Json(result);
        }
    }
}