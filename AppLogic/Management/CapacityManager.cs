using AppLogic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.InterfacesRepo;
using AppLogic.DtoCreate;
using DataAccess;
using DataAccess.Repositories;
using AppLogic.DtoUpdate;
using AppLogic.DtoConverter;

namespace AppLogic.Management
{
    public class CapacityManager : IManager<CreateCapacity, ReadCapacity, UpdateCapacity>
    {
        public ReadCapacity Add(CreateCapacity item)
        {
            using(Context context = new Context())
            {
                EfCapacityRepository rep = new EfCapacityRepository(context);
                CapacityConvert convert = new CapacityConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadCapacity Get(int id)
        {
            using (Context context = new Context())
            {
                EfCapacityRepository rep = new EfCapacityRepository(context);
                CapacityConvert convert = new CapacityConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadCapacity> GetAll()
        {
            using (Context context = new Context())
            {
                EfCapacityRepository rep = new EfCapacityRepository(context);
                CapacityConvert convert = new CapacityConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadCapacity Remove(int id)
        {
            using (Context context = new Context())
            {
                EfCapacityRepository rep = new EfCapacityRepository(context);
                CapacityConvert convert = new CapacityConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateCapacity item)
        {
            using (Context context = new Context())
            {
                EfCapacityRepository rep = new EfCapacityRepository(context);
                CapacityConvert convert = new CapacityConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
