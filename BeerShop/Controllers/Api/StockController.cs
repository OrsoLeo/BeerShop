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
    public class StockController : ApiController
    {
        StockPositionManager manager = new StockPositionManager();
        // GET: api/Stock
        public List<ReadStockPosition> Get()
        {
            return manager.GetAll();
        }

        // GET: api/Stock/5
        public ReadStockPosition Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/Stock
        public void Post([FromBody]CreateStockPosition create)
        {
            manager.Add(create);
        }

        // PUT: api/Stock/5
        public void Put(int id, [FromBody]UpdateStockPosition update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/Stock/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
