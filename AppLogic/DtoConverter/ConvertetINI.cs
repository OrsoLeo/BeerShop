using AppLogic.Dto;
using AppLogic.DtoCreate;
using AppLogic.DtoUpdate;
using AutoMapper;
using DataAccess;
using DataAccess.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoConverter
{
    public static class ConverterINI
    {
        static Context context;
        static ConverterINI()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CreateBeerBottle, BeerBottle>()
                    .ForMember("BeerEntity", opt => opt.MapFrom(c => (new EfBeerEntityRepository(context)).Get(c.BeerEntityId)))
                    .ForMember("Capacity", opt => opt.MapFrom(c => (new EfCapacityRepository(context).Get(c.CapacityId))));
                cfg.CreateMap<UpdateBeerBottle, BeerBottle>()
                    .ForMember("BeerEntity", opt => opt.MapFrom(c => (new EfBeerEntityRepository(context)).Get(c.BeerEntityId)))
                    .ForMember("Capacity", opt => opt.MapFrom(c => (new EfCapacityRepository(context).Get(c.CapacityId))));
                cfg.CreateMap<BeerBottle, ReadBeerBottle>();

                cfg.CreateMap<CreateBeerEntity, BeerEntity>()
                    .ForMember("BeerKind", opt => opt.MapFrom(c => (new EfBeerKindRepository(context)).Get(c.BeerKindId)))
                    .ForMember("TradeMark", opt => opt.MapFrom(c => (new EfTradeMarkRepository(context).Get(c.TradeMarkId))));
                cfg.CreateMap<UpdateBeerEntity, BeerEntity>()
                    .ForMember("BeerKind", opt => opt.MapFrom(c => (new EfBeerKindRepository(context)).Get(c.BeerKindId)))
                    .ForMember("TradeMark", opt => opt.MapFrom(c => (new EfTradeMarkRepository(context).Get(c.TradeMarkId))));
                cfg.CreateMap<BeerEntity, ReadBeerEntity>();

                cfg.CreateMap<CreateBeerKind, BeerKind>();
                cfg.CreateMap<UpdateBeerKind, BeerKind>();
                cfg.CreateMap<BeerKind, ReadBeerKind>();

                cfg.CreateMap<CreateCapacity, Capacity>();
                cfg.CreateMap<UpdateCapacity, Capacity>();
                cfg.CreateMap<Capacity, ReadCapacity>();

                cfg.CreateMap<CreatePicture, Picture>()
                    .ForMember("BeerBottle", opt => opt.MapFrom(c => (new EfBeerBottleRepository(context)).Get(c.BeerBottleId)));
                cfg.CreateMap<UpdatePicture, Picture>()
                    .ForMember("BeerBottle", opt => opt.MapFrom(c => (new EfBeerBottleRepository(context)).Get(c.BeerBottleId)));
                cfg.CreateMap<Picture, ReadPicture>();

                cfg.CreateMap<CreateSale, Sale>();
                cfg.CreateMap<UpdateSale, Sale>();
                cfg.CreateMap<Sale, ReadSale>();

                cfg.CreateMap<CreateSalePosition, SalePosition>()
                    .ForMember("Sale", opt => opt.MapFrom(c => (new EfSaleRepository(context)).Get(c.SaleId)))
                    .ForMember("BeerBottle", opt => opt.MapFrom(c => (new EfBeerBottleRepository(context)).Get(c.BeerBottleId)));
                cfg.CreateMap<UpdateSalePosition, SalePosition>()
                    .ForMember("Sale", opt => opt.MapFrom(c => (new EfSaleRepository(context)).Get(c.SaleId)))
                    .ForMember("BeerBottle", opt => opt.MapFrom(c => (new EfBeerBottleRepository(context)).Get(c.BeerBottleId)));
                cfg.CreateMap<SalePosition, ReadSalePosition>();

                cfg.CreateMap<CreateStockPosition, StockPosition>()
                    .ForMember("BeerBottle", opt => opt.MapFrom(c => (new EfBeerBottleRepository(context)).Get(c.BeerBottleId)));
                cfg.CreateMap<UpdateStockPosition, StockPosition>()
                    .ForMember("BeerBottle", opt => opt.MapFrom(c => (new EfBeerBottleRepository(context)).Get(c.BeerBottleId)));
                cfg.CreateMap<StockPosition, ReadStockPosition>();

                cfg.CreateMap<CreateTradeMark, TradeMark>();
                cfg.CreateMap<UpdateTradeMark, TradeMark>();
                cfg.CreateMap<TradeMark, ReadTradeMark>();
            });
        }
        public static void SetContext(Context context)
        {
            ConverterINI.context = context;
        }
    }
}
