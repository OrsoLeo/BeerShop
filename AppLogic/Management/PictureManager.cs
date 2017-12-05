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
    public class PictureManager : IManager<CreatePicture, ReadPicture, UpdatePicture>
    {
        public ReadPicture Add(CreatePicture item)
        {
            using (Context context = new Context())
            {
                EfPictureRepository rep = new EfPictureRepository(context);
                PictureConvert convert = new PictureConvert(context);
                return convert.ToRead(rep.Add(convert.ToEntity(item)));
            }
        }

        public ReadPicture Get(int id)
        {
            using (Context context = new Context())
            {
                EfPictureRepository rep = new EfPictureRepository(context);
                PictureConvert convert = new PictureConvert(context);
                return convert.ToRead(rep.Get(id));
            }
        }

        public List<ReadPicture> GetAll()
        {
            using (Context context = new Context())
            {
                EfPictureRepository rep = new EfPictureRepository(context);
                PictureConvert convert = new PictureConvert(context);
                return convert.ToReadList(rep.GetAll());
            }
        }

        public ReadPicture Remove(int id)
        {
            using (Context context = new Context())
            {
                EfPictureRepository rep = new EfPictureRepository(context);
                PictureConvert convert = new PictureConvert(context);
                return convert.ToRead(rep.Remove(id));
            }
        }

        public bool Update(UpdatePicture item)
        {
            using (Context context = new Context())
            {
                EfPictureRepository rep = new EfPictureRepository(context);
                PictureConvert convert = new PictureConvert(context);
                return rep.Update(convert.ToEntity(item));
            }
        }
    }
}
