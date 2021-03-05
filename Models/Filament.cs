using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public partial class Filament
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Kleur { get; set; }
        public decimal KostPerRol { get; set; }
        public decimal AantalKg { get; set; }
        private decimal aantalMeterValue;
        public decimal AantalMeter { get { return this.aantalMeterValue; } set { this.aantalMeterValue = AantalKg * 330m; } }
    }
}
