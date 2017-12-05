using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfSalePositionRepository : IRepository<SalePosition>
    {
        static Context context;
        public EfSalePositionRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public SalePosition Add(SalePosition item)
        {
            context.SalePositions.Add(item);
            context.SaveChanges();
            return item;
        }

        public SalePosition Get(int id)
        {
            return context.SalePositions.ToList().Find(s => s.ID == id);
        }

        public IEnumerable<SalePosition> GetAll()
        {
            return context.SalePositions;
        }

        public SalePosition Remove(int id)
        {
            SalePosition item = Get(id);
            context.SalePositions.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(SalePosition item)
        {
            int index = context.SalePositions.ToList().FindIndex(s => s.ID == item.ID);
            if (index == -1)
                return false;
            context.SalePositions.ToList().RemoveAt(index);
            context.SalePositions.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
