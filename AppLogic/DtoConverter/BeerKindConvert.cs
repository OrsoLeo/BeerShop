using AppLogic.Dto;
using AppLogic.DtoCreate;
using AppLogic.DtoUpdate;
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
    public class BeerKindConvert : Converter<BeerKind, CreateBeerKind, ReadBeerKind, UpdateBeerKind>
    {
        public BeerKindConvert(Context context) : base(context)
        {
            ConverterINI.SetContext(context);
        }
    }
}
