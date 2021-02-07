using Kostenberekening_3D_printer_ASPnet.Models;
using Kostenberekening_3D_printer_ASPnet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Controllers
{
    public class HomeController : Controller
    {
        private FilamentService _filamentService;

        public HomeController(FilamentService filamentService)
        {
            _filamentService = filamentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult FilamentenLijst()
        {
            var filamenten = _filamentService.FindAll();
            return View(filamenten);
        }

        public IActionResult Verwijderen(int id)
        {
            var filament = _filamentService.Read(id);
            return View(filament);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var filament = _filamentService.Read(id);
            this.TempData["filament"] = JsonConvert.SerializeObject(filament);
            _filamentService.Delete(id);
            return Redirect("~/Home/Verwijderd");
        }

        public IActionResult Verwijderd()
        {
            var filament = JsonConvert.DeserializeObject<Filament>((string)this.TempData["filament"]);
            return View(filament);
        }

        [HttpGet]
        public IActionResult Toevoegen()
        {
            var filament = new Filament();
            return View(filament);
        }

        [HttpPost]
        public IActionResult Toevoegen(Filament f)
        {
            _filamentService.Add(f);
            return RedirectToAction("Filamentenlijst");
        }

        public IActionResult BerekenKost()
        {

            return View();
        }

        //public decimal KostPerMeter()
        //{
            
        //    decimal kostPermeter = KostPerRol / AantalMeter;
        //    return kostPermeter;
        //}
    }
}
