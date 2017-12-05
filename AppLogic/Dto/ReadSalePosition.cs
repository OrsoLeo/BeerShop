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
        
        public int BottleCount { get; set; }

        public decimal Summ { get; set; }

        public ReadBeerBottle BeerBottle { get; set; }

        public ReadSale Sale { get; set; }
    }
}
