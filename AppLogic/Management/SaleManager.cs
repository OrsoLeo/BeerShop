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
    public class SaleManager : IManager<CreateSale, ReadSale, UpdateSale>
    {
        public ReadSale Add(CreateSale item)
        {
            using(Context context = new Context())
            {
                EfSaleRepository rep = new EfSaleRepository(context);
                SaleConvert convert = new SaleConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadSale Get(int id)
        {
            using (Context context = new Context())
            {
                EfSaleRepository rep = new EfSaleRepository(context);
                SaleConvert convert = new SaleConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadSale> GetAll()
        {
            using (Context context = new Context())
            {
                EfSaleRepository rep = new EfSaleRepository(context);
                SaleConvert convert = new SaleConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadSale Remove(int id)
        {
            using (Context context = new Context())
            {
                EfSaleRepository rep = new EfSaleRepository(context);
                SaleConvert convert = new SaleConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdateSale item)
        {
            using (Context context = new Context())
            {
                EfSaleRepository rep = new EfSaleRepository(context);
                SaleConvert convert = new SaleConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
