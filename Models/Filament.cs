using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public enum Types
    {
        PLA,
        ABS,
        PETG,
        TPE
    }
    public enum Kleuren
    {
        Roze,
        Geel,
        Wit,
        Oranje,
        Blauw,
        Groen,
        Transparant
    }
    public class Filament
    {
        public Types Type { get; set; }
        public decimal KostPerRol { get; set; }
        public int AantalMeter { get => 330; }

        public decimal KostPerMeter()
        {
            decimal kostPermeter = KostPerRol / AantalMeter;
            return kostPermeter;
        }
    }
}
