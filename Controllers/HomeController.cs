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

        public IActionResult BerekenKost(Print p)
        {
            p.KostPerPrint = (p.KostPerRol / 330) * p.AantalMeterPrint + (0.0534m * (p.Duurtijd / 60));
            return View(p);
        }
    }
}
