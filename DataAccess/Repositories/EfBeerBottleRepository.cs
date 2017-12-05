using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfBeerBottleRepository : IRepository<BeerBottle>
    {
        static Context context;
        public EfBeerBottleRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public BeerBottle Add(BeerBottle item)
        {
            context.BeerBottles.Add(item);
            context.SaveChanges();
            return item;
        }

        public BeerBottle Get(int id)
        {
            return context.BeerBottles.ToList().Find(b => b.ID == id);
        }

        public IEnumerable<BeerBottle> GetAll()
        {
            return context.BeerBottles;
        }

        public BeerBottle Remove(int id)
        {
            BeerBottle item = context.BeerBottles.ToList().Find(b => b.ID == id);
            context.BeerBottles.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(BeerBottle item)
        {
            //int index = context.BeerBottles.ToList().FindIndex(b => b.ID == item.ID);
            //if (index == -1)
            //    return false;
            //context.BeerBottles.ToList().RemoveAt(index);
            Remove(item.ID);
            context.BeerBottles.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
