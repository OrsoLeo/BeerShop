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

        public ReadBeerBottle BeerBottle { get; set; }
    }
}
