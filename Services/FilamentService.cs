using Kostenberekening_3D_printer_ASPnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Services
{
    public class FilamentService
    {
        private Dictionary<int, Filament1> filamenten = new Dictionary<int, Filament1>();
        public FilamentService()
        {
            filamenten[1] = new Filament1
            {
                ID = 1,
                Type = Types.PLA,
                Kleur = Kleuren.Groen,
                KostPerRol = 19.5m,
                AantalKg = 0.5m
            };
            filamenten[2] = new Filament1
            {
                ID = 2,
                Type = Types.PLA,
                Kleur = Kleuren.Wit,
                KostPerRol = 19.5m,
                AantalKg = 1m
            };
            filamenten[3] = new Filament1
            {
                ID = 3,
                Type = Types.PETG,
                Kleur = Kleuren.Geel,
                KostPerRol = 19.5m,
                AantalKg = 1m
            };  
        }

        public List<Filament1> FindAll()
        {
            return filamenten.Values.ToList();
        }
        public Filament1 Read(int id)
        {
            return filamenten[id];
        }
        public void Delete(int id)
        {
            filamenten.Remove(id);
        }

        public void Add(Filament1 f)
        {
            f.ID = filamenten.Keys.Max() + 1;
            filamenten.Add(f.ID, f);
        }
    }
}
