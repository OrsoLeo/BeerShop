using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfSaleRepository : IRepository<Sale>
    {
        static Context context;
        public EfSaleRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public Sale Add(Sale item)
        {
            context.Sales.Add(item);
            context.SaveChanges();
            return item;
        }

        public Sale Get(int id)
        {
            return context.Sales.ToList().Find(s => s.ID == id);
        }

        public IEnumerable<Sale> GetAll()
        {
            return context.Sales;
        }

        public Sale Remove(int id)
        {
            Sale item = Get(id);
            context.Sales.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(Sale item)
        {
            int index = context.Sales.ToList().FindIndex(s => s.ID == item.ID);
            if (index == -1)
                return false;
            context.Sales.ToList().RemoveAt(index);
            context.Sales.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
