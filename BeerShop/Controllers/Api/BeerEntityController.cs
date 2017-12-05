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
    public class BeerEntityController : ApiController
    {
        BeerEntityManager manager = new BeerEntityManager();
        // GET: api/BeerEntity
        public List<ReadBeerEntity> Get()
        {
            return manager.GetAll();
        }

        // GET: api/BeerEntity/5
        public ReadBeerEntity Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/BeerEntity
        public void Post([FromBody]CreateBeerEntity create)
        {
            manager.Add(create);
        }

        // PUT: api/BeerEntity/5
        public void Put(int id, [FromBody]UpdateBeerEntity update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/BeerEntity/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
