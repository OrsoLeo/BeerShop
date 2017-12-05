using AutoMapper;
using DataAccess;
using Domain.Entities;
using Domain.InterfacesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoConverter
{
    public abstract class Converter<entity, create, read, update> : IConverter<entity, create, read, update>
    {
        static Context context;
        public Converter(Context _context)
        {
            context = _context;
        }

        public virtual entity ToEntity(create item)
        {
            return Mapper.Map<create, entity>(item);
        }

        public virtual entity ToEntity(update item)
        {
            return Mapper.Map<update, entity>(item);
        }

        public read ToRead(entity item)
        {
            return Mapper.Map<entity, read>(item);
        }

        public List<read> ToReadList(IEnumerable<entity> collection)
        {
            return Mapper.Map<IEnumerable<entity>, List<read>>(collection);
        }
    }
    //public abstract class ReadConverter<entity, read> : IConverter<entity, read>
    //{
    //    public read ToRead(entity item)
    //    {
    //        Mapper.Initialize(cfg => cfg.CreateMap<entity, read>());
    //        return Mapper.Map<entity, read>(item);
    //    }

    //    public List<read> ToReadList(IEnumerable<entity> collection)
    //    {
    //        Mapper.Initialize(cfg => cfg.CreateMap<entity, read>());
    //        return Mapper.Map<IEnumerable<entity>, List<read>>(collection);
    //    }
    //}
    //public class SimpleConverter<entity, create, read, update> : ReadConverter<entity, read>, IConverter<entity, create, read, update>
    //{
    //    //public entity CreateToEntity(create item)
    //    //{
    //    //    Mapper.Initialize(cfg => cfg.CreateMap<create, entity>());
    //    //    return Mapper.Map<create, entity>(item);
    //    //}
    //    //public entity UpdateToEntity(update item)
    //    //{
    //    //    Mapper.Initialize(cfg => cfg.CreateMap<update, entity>());
    //    //    return Mapper.Map<update, entity>(item);
    //    //}
    //    public virtual entity ToEntity(create item)
    //    {
    //        Mapper.Initialize(cfg => cfg.CreateMap<create, entity>());
    //        return Mapper.Map<create, entity>(item);
    //    }
    //    public virtual entity ToEntity(update item)
    //    {
    //        Mapper.Initialize(cfg => cfg.CreateMap<update, entity>());
    //        return Mapper.Map<update, entity>(item);
    //    }

    //}
    //public class ComplicatedConverter<entity, create, read, update> : SimpleConverter<entity, create, read, update>//ReadConverter<entity, read>
    //{
    //    public Context Context { get; set; }
    //    public ComplicatedConverter(Context context)
    //    {
    //        Context = context;
    //    }

        //public virtual entity CreateToEntity(create item)
        //{
        //    Mapper.Initialize(cfg => cfg.CreateMap<create, entity>());
        //    return Mapper.Map<create, entity>(item);
        //}
        //public virtual entity UpdateToEntity(update item)
        //{
        //    Mapper.Initialize(cfg => cfg.CreateMap<update, entity>());
        //    return Mapper.Map<update, entity>(item);
        //}
    //}
}
