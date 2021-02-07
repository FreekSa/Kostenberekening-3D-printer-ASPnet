﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public class Print : Filament
    {
        public decimal Duurtijd { get; set; }
        public int AantalMeterPrint { get; set; }

        public Print(string type, decimal kostPerRol, int aantalMeterPrint, decimal duurtijd)/* : base(type, kostPerRol)*/
        {
            Duurtijd = duurtijd;
            AantalMeterPrint = aantalMeterPrint;
        }

        public decimal BerekenKostprijs()
        {
            var kostPerPrint = (KostPerRol / AantalMeter) * AantalMeterPrint + 0.0534m * (Duurtijd / 60);
            return kostPerPrint;                                                               //0.0534 = kost per kwh (elektriciteit)
        }
    }
}
