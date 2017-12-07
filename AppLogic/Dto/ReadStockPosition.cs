using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Dto
{
    public class ReadStockPosition
    {
        public int ID { get; set; }
        public int BottleCount { get; set; }        
        public int BeerBottleID { get; set; }
        public DateTime BeerBottleDateOfSpill { get; set; }
        public decimal BeerBottlePrice { get; set; }
        public int CapacityID { get; set; }
        public float Cap { get; set; }
        public int BeerEntityID { get; set; }
        public string BeerEntityName { get; set; }
        public double BeerEntityAlcohol { get; set; }
        public double BeerEntityBreadness { get; set; }
        public int BeerKindID { get; set; }
        public string BeerKindName { get; set; }
        public int TradeMarkID { get; set; }
        public string TradeMarkName { get; set; }
        public string TradeMarkSpecification { get; set; }
        public int PictureID { get; set; }
        public string PicturePath { get; set; }
    }
}
