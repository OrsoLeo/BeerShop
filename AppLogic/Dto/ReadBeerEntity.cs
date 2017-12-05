using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Dto
{
    public class ReadBeerEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Alcohol { get; set; }

        public double Breadness { get; set; }
        
        public ReadBeerKind BeerKind { get; set; }

        public ReadTradeMark TradeMark { get; set; }
    }
}
