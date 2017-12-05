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
    public class TradeMarkManager : IManager<CreateTradeMark, ReadTradeMark, UpdateTradeMark>
    {
        public ReadTradeMark Add(CreateTradeMark item)
        {
            using (Context context = new Context())
            {
                EfTradeMarkRepository rep = new EfTradeMarkRepository(context);
                TradeMarkConvert convert = new TradeMarkConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadTradeMark Get(int id)
        {
            using (Context context = new Context())
            {
                EfTradeMarkRepository rep = new EfTradeMarkRepository(context);
                TradeMarkConvert convert = new TradeMarkConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadTradeMark> GetAll()
        {
            using (Context context = new Context())
            {
                EfTradeMarkRepository rep = new EfTradeMarkRepository(context);
                TradeMarkConvert convert = new TradeMarkConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadTradeMark Remove(int id)
        {
            using (Context context = new Context())
            {
                EfTradeMarkRepository rep = new EfTradeMarkRepository(context);
                TradeMarkConvert convert = new TradeMarkConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateTradeMark item)
        {
            using (Context context = new Context())
            {
                EfTradeMarkRepository rep = new EfTradeMarkRepository(context);
                TradeMarkConvert convert = new TradeMarkConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
