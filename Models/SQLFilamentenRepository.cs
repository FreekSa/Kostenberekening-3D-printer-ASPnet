using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kostenberekening_3D_printer_ASPnet.Models
{
    public class SQLFilamentenRepository : IFilamentenRepository
    {
        private readonly FilamentenlijstContext context;
        public SQLFilamentenRepository(FilamentenlijstContext context)
        {
            this.context = context;
        }

        public Filament Add(Filament filament)
        {
            context.Stock.Add(filament);
            context.SaveChanges();
            return filament;
        }

        public Filament Delete(int id)
        {
            Filament filament = context.Stock.Find(id);
            if(filament != null)
            {
                context.Stock.Remove(filament);
                context.SaveChanges();
            }
            return filament;
        }

        public Filament GetFilament(int id)
        {
            return context.Stock.Find(id);
        }

        public IEnumerable<Filament> GetFilamenten()
        {
            return context.Stock;
        }

        public Filament Update(Filament gewijzigdFilament)
        {
            var filament = context.Stock.Attach(gewijzigdFilament);
            filament.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return gewijzigdFilament;
        }
    }
}
