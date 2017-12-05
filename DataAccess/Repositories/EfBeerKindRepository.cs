using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfBeerKindRepository : IRepository<BeerKind>
    {
        static Context context;
        public EfBeerKindRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public BeerKind Add(BeerKind item)
        {
            context.BeerKinds.Add(item);
            context.SaveChanges();
            return item;
        }

        public BeerKind Get(int id)
        {
            return context.BeerKinds.ToList().Find(b => b.ID == id);
        }

        public IEnumerable<BeerKind> GetAll()
        {
            return context.BeerKinds;
        }

        public BeerKind Remove(int id)
        {
            BeerKind item = Get(id);
            context.BeerKinds.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(BeerKind item)
        {
            int index = context.BeerKinds.ToList().FindIndex(b => b.ID == item.ID);
            if (index == -1)
                return false;
            context.BeerKinds.ToList().RemoveAt(index);
            context.BeerKinds.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
