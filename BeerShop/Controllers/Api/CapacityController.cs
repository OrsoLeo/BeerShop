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
    public class CapacityController : ApiController
    {
        CapacityManager manager = new CapacityManager();
        // GET: api/Capacity
        public List<ReadCapacity> Get()
        {
            return manager.GetAll();
        }

        // GET: api/Capacity/5
        public ReadCapacity Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/Capacity
        public void Post([FromBody]CreateCapacity create)
        {
            manager.Add(create);
        }

        // PUT: api/Capacity/5
        public void Put(int id, [FromBody]UpdateCapacity update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/Capacity/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
