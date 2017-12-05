using AppLogic.Dto;
using AppLogic.DtoCreate;
using AppLogic.DtoUpdate;
using AppLogic.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeerShop.Controllers
{
    public class SalePositionController : ApiController
    {
        SalePositionManager manager = new SalePositionManager();
        // GET: api/SalePosition
        public List<ReadSalePosition> Get()
        {
            return manager.GetAll();
        }

        // GET: api/SalePosition/5
        public ReadSalePosition Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/SalePosition
        public void Post([FromBody]CreateSalePosition create)
        {
            manager.Add(create);
        }

        // PUT: api/SalePosition/5
        public void Put(int id, [FromBody]UpdateSalePosition update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/SalePosition/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
