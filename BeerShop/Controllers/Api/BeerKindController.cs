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
    public class BeerKindController : ApiController
    {
        BeerKindManager manager = new BeerKindManager();
        // GET: api/BeerKind
        public List<ReadBeerKind> Get()
        {
            return manager.GetAll();
        }

        // GET: api/BeerKind/5
        public ReadBeerKind Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/BeerKind
        public void Post([FromBody]CreateBeerKind create)
        {
            manager.Add(create);
        }

        // PUT: api/BeerKind/5
        public void Put(int id, [FromBody]UpdateBeerKind update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/BeerKind/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
