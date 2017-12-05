using Domain.Entities;
using Domain.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfPictureRepository : IRepository<Picture>
    {
        static Context context;
        public EfPictureRepository(Context dbcontext)
        {
            context = dbcontext;
        }

        public Picture Add(Picture item)
        {
            context.Pictures.Add(item);
            context.SaveChanges();
            return item;
        }

        public Picture Get(int id)
        {
            return context.Pictures.ToList().Find(p => p.ID == id);
        }

        public IEnumerable<Picture> GetAll()
        {
            return context.Pictures;
        }

        public Picture Remove(int id)
        {
            Picture item = Get(id);
            context.Pictures.Remove(item);
            context.SaveChanges();
            return item;
        }

        public bool Update(Picture item)
        {
            int index = context.Pictures.ToList().FindIndex(p => p.ID == item.ID);
            if (index == -1)
                return false;
            context.Pictures.ToList().RemoveAt(index);
            context.Pictures.Add(item);
            context.SaveChanges();
            return true;
        }
    }
}
