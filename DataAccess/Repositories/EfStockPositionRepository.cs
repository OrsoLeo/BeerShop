using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfStockPositionRepository : IRepository<StockPosition>
    {
        static Context context;
        public EfStockPositionRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public StockPosition Add(StockPosition item)
        {
            context.StockPositions.Add(item);
            context.SaveChanges();
            return item;
        }

        public StockPosition Get(int id)
        {
            return context.StockPositions.ToList().Find(s => s.ID == id);
        }

        public IEnumerable<StockPosition> GetAll()
        {
            return context.StockPositions;
        }

        public StockPosition Remove(int id)
        {
            StockPosition item = Get(id);
            context.StockPositions.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(StockPosition item)
        {
            int index = context.StockPositions.ToList().FindIndex(s => s.ID == item.ID);
            if (index == -1)
                return false;
            context.StockPositions.ToList().RemoveAt(index);
            context.StockPositions.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
