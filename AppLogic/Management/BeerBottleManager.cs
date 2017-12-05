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
    public class BeerBottleManager : IManager<CreateBeerBottle, ReadBeerBottle, UpdateBeerBottle>
    {
        public ReadBeerBottle Add(CreateBeerBottle item)
        {
            using (Context context = new Context())
            {
                EfBeerBottleRepository rep = new EfBeerBottleRepository(context);
                BeerBottleConvert convert = new BeerBottleConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadBeerBottle Get(int id)
        {
            using (Context context = new Context())
            {
                EfBeerBottleRepository rep = new EfBeerBottleRepository(context);
                BeerBottleConvert convert = new BeerBottleConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadBeerBottle> GetAll()
        {
            using (Context context = new Context())
            {
                EfBeerBottleRepository rep = new EfBeerBottleRepository(context);
                BeerBottleConvert convert = new BeerBottleConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadBeerBottle Remove(int id)
        {
            using (Context context = new Context())
            {
                EfBeerBottleRepository rep = new EfBeerBottleRepository(context);
                BeerBottleConvert convert = new BeerBottleConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateBeerBottle item)
        {
            using (Context context = new Context())
            {
                EfBeerBottleRepository rep = new EfBeerBottleRepository(context);
                BeerBottleConvert convert = new BeerBottleConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
