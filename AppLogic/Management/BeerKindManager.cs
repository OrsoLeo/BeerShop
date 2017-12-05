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
    public class BeerKindManager : IManager<CreateBeerKind, ReadBeerKind, UpdateBeerKind>
    {
        public ReadBeerKind Add(CreateBeerKind item)
        {
            using(Context context = new Context())
            {
                EfBeerKindRepository rep = new EfBeerKindRepository(context);
                BeerKindConvert convert = new BeerKindConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadBeerKind Get(int id)
        {
            using (Context context = new Context())
            {
                EfBeerKindRepository rep = new EfBeerKindRepository(context);
                BeerKindConvert convert = new BeerKindConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadBeerKind> GetAll()
        {
            using (Context context = new Context())
            {
                EfBeerKindRepository rep = new EfBeerKindRepository(context);
                BeerKindConvert convert = new BeerKindConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadBeerKind Remove(int id)
        {
            using (Context context = new Context())
            {
                EfBeerKindRepository rep = new EfBeerKindRepository(context);
                BeerKindConvert convert = new BeerKindConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateBeerKind item)
        {
            using (Context context = new Context())
            {
                EfBeerKindRepository rep = new EfBeerKindRepository(context);
                BeerKindConvert convert = new BeerKindConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
