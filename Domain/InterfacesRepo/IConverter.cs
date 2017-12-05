using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterfacesRepo
{
    public interface IConverter
    {
    }
    public interface IConverter<entity, create, read, update> : IConverter
    {
        read ToRead(entity item);
        List<read> ToReadList(IEnumerable<entity> collection);
        entity ToEntity(create item);
        entity ToEntity(update item);
    }
}
