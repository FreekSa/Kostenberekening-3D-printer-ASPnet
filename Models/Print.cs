using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public class Print : Filament
    {
        public decimal Duurtijd { get; set; }
        public decimal AantalMeterPrint { get; set; }
        [DisplayFormat(DataFormatString="{0:#.##}")]
        public decimal KostPerPrint { get; set; }
    }
}
