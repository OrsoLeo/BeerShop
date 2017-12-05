using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfTradeMarkRepository : IRepository<TradeMark>
    {
        static Context context;
        public EfTradeMarkRepository(Context dbcontext)
        {
            context = dbcontext;
        }
        public TradeMark Add(TradeMark item)
        {
            context.TradeMarks.Add(item);
            context.SaveChanges();
            return item;
        }

        public TradeMark Get(int id)
        {
            return context.TradeMarks.ToList().Find(t => t.ID == id);
        }

        public IEnumerable<TradeMark> GetAll()
        {
            return context.TradeMarks;
        }

        public TradeMark Remove(int id)
        {
            TradeMark item = Get(id);
            context.TradeMarks.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(TradeMark item)
        {
            int index = context.TradeMarks.ToList().FindIndex(t => t.ID == item.ID);
            if (index == -1)
                return false;
            context.TradeMarks.ToList().RemoveAt(index);
            context.TradeMarks.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
