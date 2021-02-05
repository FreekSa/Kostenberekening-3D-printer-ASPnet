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
        public int ID { get; set; }
        public Types Type { get; set; }
        public Kleuren Kleur { get; set; }
        public decimal KostPerRol { get; set; }
        public int AantalMeter { get => 330; }

        
    }
}
