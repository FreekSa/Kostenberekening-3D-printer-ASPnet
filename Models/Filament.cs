using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public class Filament
    {
        string Type { get; set; }
        decimal KostPerRol { get; set; }
        int AantalMeter { get; set; }
        public decimal KostprijsPrint { get; set; }

        public Filament(string type, decimal kostPerRol)
        {
            //In program.cs is Type vastgezet als PLA
            Type = type;
            KostPerRol = kostPerRol;
            AantalMeter = 330;
        }

        public decimal KostPerMeter()
        {
            decimal kostPermeter = KostPerRol / AantalMeter;
            return kostPermeter;
        }
    }
}
