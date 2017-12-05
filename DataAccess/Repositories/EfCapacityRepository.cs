using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfCapacityRepository : IRepository<Capacity>
    {
        static Context context;
        public EfCapacityRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public Capacity Add(Capacity item)
        {
            context.Capacities.Add(item);
            context.SaveChanges();
            return item;
        }

        public Capacity Get(int id)
        {
            return context.Capacities.ToList().Find(c => c.ID == id);
        }

        public IEnumerable<Capacity> GetAll()
        {
            return context.Capacities;
        }

        public Capacity Remove(int id)
        {
            Capacity item = Get(id);
            context.Capacities.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(Capacity item)
        {
            int index = context.Capacities.ToList().FindIndex(c => c.ID == item.ID);
            if (index == -1)
                return false;
            context.Capacities.ToList().RemoveAt(index);
            context.Capacities.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
