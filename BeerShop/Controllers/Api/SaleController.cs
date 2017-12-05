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
    public class SaleController : ApiController
    {
        SaleManager manager = new SaleManager();
        // GET: api/Sale
        public List<ReadSale> Get()
        {
            return manager.GetAll();
        }

        // GET: api/Sale/5
        public ReadSale Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/Sale
        public void Post([FromBody]CreateSale create)
        {
            manager.Add(create);
        }

        // PUT: api/Sale/5
        public void Put(int id, [FromBody]UpdateSale update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/Sale/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
