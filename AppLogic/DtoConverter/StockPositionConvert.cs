using AppLogic.Dto;
using AppLogic.DtoCreate;
using AppLogic.DtoUpdate;
using AutoMapper;
using DataAccess;
using DataAccess.Repositories;
using Domain.Entities;
using Domain.InterfacesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoConverter
{
    public class StockPositionConvert : Converter<StockPosition, CreateStockPosition, ReadStockPosition, UpdateStockPosition>
    {
        public StockPositionConvert(Context context) : base(context)
        {
            ConverterINI.SetContext(context);
        }
    }
}
