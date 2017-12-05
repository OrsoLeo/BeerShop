using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterfacesRepo
{
    public interface IManager<create, read, update>
    {
        read Add(create item);
        List<read> GetAll();
        read Get(int id);
        bool Update(update item);
        read Remove(int id);
    }
}
