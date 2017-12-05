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
    public class SalePositionManager : IManager<CreateSalePosition, ReadSalePosition, UpdateSalePosition>
    {
        public ReadSalePosition Add(CreateSalePosition item)
        {
            using (Context context = new Context())
            {
                EfSalePositionRepository rep = new EfSalePositionRepository(context);
                SalePositionConvert convert = new SalePositionConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadSalePosition Get(int id)
        {
            using (Context context = new Context())
            {
                EfSalePositionRepository rep = new EfSalePositionRepository(context);
                SalePositionConvert convert = new SalePositionConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadSalePosition> GetAll()
        {
            using (Context context = new Context())
            {
                EfSalePositionRepository rep = new EfSalePositionRepository(context);
                SalePositionConvert convert = new SalePositionConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadSalePosition Remove(int id)
        {
            using (Context context = new Context())
            {
                EfSalePositionRepository rep = new EfSalePositionRepository(context);
                SalePositionConvert convert = new SalePositionConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateSalePosition item)
        {
            using (Context context = new Context())
            {
                EfSalePositionRepository rep = new EfSalePositionRepository(context);
                SalePositionConvert convert = new SalePositionConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
