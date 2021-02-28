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
            context.Filamenten.Add(filament);
            context.SaveChanges();
            return filament;
        }

        public Filament Delete(int id)
        {
            Filament filament = context.Filamenten.Find(id);
            if(filament != null)
            {
                context.Filamenten.Remove(filament);
                context.SaveChanges();
            }
            return filament;
        }

        public Filament GetFilament(int id)
        {
            return context.Filamenten.Find(id);
        }

        public IEnumerable<Filament> GetFilamenten()
        {
            return context.Filamenten;
        }

        public Filament Update(Filament gewijzigdFilament)
        {
            var filament = context.Filamenten.Attach(gewijzigdFilament);
            filament.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return gewijzigdFilament;
        }
    }
}
