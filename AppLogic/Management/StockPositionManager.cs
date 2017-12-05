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
    public class StockPositionManager : IManager<CreateStockPosition, ReadStockPosition, UpdateStockPosition>
    {
        public ReadStockPosition Add(CreateStockPosition item)
        {
            using (Context context = new Context())
            {
                EfStockPositionRepository rep = new EfStockPositionRepository(context);
                StockPositionConvert convert = new StockPositionConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadStockPosition Get(int id)
        {
            using (Context context = new Context())
            {
                EfStockPositionRepository rep = new EfStockPositionRepository(context);
                StockPositionConvert convert = new StockPositionConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadStockPosition> GetAll()
        {
            using (Context context = new Context())
            {
                EfStockPositionRepository rep = new EfStockPositionRepository(context);
                StockPositionConvert convert = new StockPositionConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadStockPosition Remove(int id)
        {
            using (Context context = new Context())
            {
                EfStockPositionRepository rep = new EfStockPositionRepository(context);
                StockPositionConvert convert = new StockPositionConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateStockPosition item)
        {
            using (Context context = new Context())
            {
                EfStockPositionRepository rep = new EfStockPositionRepository(context);
                StockPositionConvert convert = new StockPositionConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
