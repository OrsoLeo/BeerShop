using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfBeerEntityRepository : IRepository<BeerEntity>
    {
        static Context context;
        public EfBeerEntityRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public BeerEntity Add(BeerEntity item)
        {
            context.BeerEntities.Add(item);
            context.SaveChanges();
            return item;
        }

        public BeerEntity Get(int id)
        {
            return context.BeerEntities.ToList().Find(b => b.ID == id);
        }

        public IEnumerable<BeerEntity> GetAll()
        {
            return context.BeerEntities;
        }

        public BeerEntity Remove(int id)
        {
            BeerEntity item = Get(id);
            context.BeerEntities.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(BeerEntity item)
        {
            int index = context.BeerEntities.ToList().FindIndex(b => b.ID == item.ID);
            if (index == -1)
                return false;
            context.BeerEntities.ToList().RemoveAt(index);
            context.BeerEntities.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
