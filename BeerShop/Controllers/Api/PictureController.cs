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
    public class PictureController : ApiController
    {
        PictureManager manager = new PictureManager();
        // GET: api/Picture
        public List<ReadPicture> Get()
        {
            return manager.GetAll();
        }

        // GET: api/Picture/5
        public ReadPicture Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/Picture
        public void Post([FromBody]CreatePicture create)
        {
            manager.Add(create);
        }

        // PUT: api/Picture/5
        public void Put(int id, [FromBody]UpdatePicture update)
        {
            if (id == update.ID)
            {
                manager.Update(update);
            }
        }

        // DELETE: api/Picture/5
        public void Delete(int id)
        {
            manager.Remove(id);
        }
    }
}
