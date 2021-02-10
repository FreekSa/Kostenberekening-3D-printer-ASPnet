using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public class Print : Filament
    {
        public decimal Duurtijd { get; set; }
        public decimal AantalMeterPrint { get; set; }
        public decimal KostPerPrint { get; set; }
    }
}
