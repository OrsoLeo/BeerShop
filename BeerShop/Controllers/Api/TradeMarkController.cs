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
    public class TradeMarkController : ApiController
    {
        TradeMarkManager manager = new TradeMarkManager();
        // GET: api/TradeMark
        public List<ReadTradeMark> Get()
        {
            return manager.GetAll();
        }

        // GET: api/TradeMark/5
        public ReadTradeMark Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/TradeMark
        public void Post([FromBody]CreateTradeMark create)
        {
            manager.Add(create);
        }

        // PUT: api/TradeMark/5
        public void Put(int id, [FromBody]UpdateTradeMark update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/TradeMark/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
