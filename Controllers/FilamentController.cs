using Kostenberekening_3D_printer_ASPnet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Controllers
{
    public class FilamentController : Controller
    {
        private readonly IFilamentenRepository filamentenRepository;
        public FilamentController(IFilamentenRepository filamentenRepository)
        {
            this.filamentenRepository = filamentenRepository;
        }
        public IActionResult Index()
        {
            return View(filamentenRepository.GetFilamenten());
        }
    }
}
