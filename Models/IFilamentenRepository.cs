using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public interface IFilamentenRepository
    {
        Filament GetFilament(int id);
        IEnumerable<Filament> GetFilamenten();
        Filament Add(Filament filament);
        Filament Update(Filament gewijzigdFilament);
        Filament Delete(int id);
    }
}
