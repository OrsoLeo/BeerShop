using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Dto
{
    public class ReadSalePosition
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        public int BottleCount { get; set; }

        public decimal Summ { get; set; }

        public int BeerBottleID { get; set; }

        public decimal BeerBottlePrice { get; set; }

        public int SaleID { get; set; }
    }
}
