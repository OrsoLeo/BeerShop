using AppLogic.Dto;
using AppLogic.DtoCreate;
using AppLogic.DtoUpdate;
using Domain.InterfacesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Management
{
    public class Manager
    {
        public IManager<CreateBeerBottle, ReadBeerBottle, UpdateBeerBottle> BeerBottles { get; set; }
        public IManager<CreateBeerEntity, ReadBeerEntity, UpdateBeerEntity> BeerEntities { get; set; }
        public IManager<CreateBeerKind, ReadBeerKind, UpdateBeerKind> BeerKinds { get; set; }
        public IManager<CreateCapacity, ReadCapacity, UpdateCapacity> Capacities { get; set; }
        public IManager<CreatePicture, ReadPicture, UpdatePicture> Pictures { get; set; }
        public IManager<CreateSale, ReadSale, UpdateSale> Sales { get; set; }
        public IManager<CreateSalePosition, ReadSalePosition, UpdateSalePosition> SalePositions { get; set; }
        public IManager<CreateStockPosition, ReadStockPosition, UpdateStockPosition> Stock { get; set; }
        public IManager<CreateTradeMark, ReadTradeMark, UpdateTradeMark> TradeMarks { get; set; }

        public Manager()
        {
            BeerBottles = new BeerBottleManager();
            BeerEntities = new BeerEntityManager();
            BeerKinds = new BeerKindManager();
            Capacities = new CapacityManager();
            Pictures = new PictureManager();
            Sales = new SaleManager();
            SalePositions = new SalePositionManager();
            Stock = new StockPositionManager();
            TradeMarks = new TradeMarkManager();
        }
    }
}
