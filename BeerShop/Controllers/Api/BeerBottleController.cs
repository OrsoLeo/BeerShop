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
    public class BeerBottleController : ApiController 
    {
        BeerBottleManager manager = new BeerBottleManager();
        // GET: api/BeerBottle
        public List<ReadBeerBottle> Get()
        {
            return manager.GetAll();
        }

        // GET: api/BeerBottle/5
        public ReadBeerBottle Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/BeerBottle
        public void Post([FromBody]CreateBeerBottle create)
        {
            manager.Add(create);
        }

        // PUT: api/BeerBottle/5
        public void Put(int id, [FromBody]UpdateBeerBottle update)
        {
            if(id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/BeerBottle/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
