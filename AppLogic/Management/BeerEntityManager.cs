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
    public class BeerEntityManager : IManager<CreateBeerEntity, ReadBeerEntity, UpdateBeerEntity>
    {
        public ReadBeerEntity Add(CreateBeerEntity item)
        {
            using(Context context = new Context())
            {
                EfBeerEntityRepository rep = new EfBeerEntityRepository(context);
                BeerEntityConvert convert = new BeerEntityConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadBeerEntity Get(int id)
        {
            using (Context context = new Context())
            {
                EfBeerEntityRepository rep = new EfBeerEntityRepository(context);
                BeerEntityConvert convert = new BeerEntityConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadBeerEntity> GetAll()
        {
            using (Context context = new Context())
            {
                EfBeerEntityRepository rep = new EfBeerEntityRepository(context);
                BeerEntityConvert convert = new BeerEntityConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadBeerEntity Remove(int id)
        {
            using (Context context = new Context())
            {
                EfBeerEntityRepository rep = new EfBeerEntityRepository(context);
                BeerEntityConvert convert = new BeerEntityConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateBeerEntity item)
        {
            using (Context context = new Context())
            {
                EfBeerEntityRepository rep = new EfBeerEntityRepository(context);
                BeerEntityConvert convert = new BeerEntityConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
