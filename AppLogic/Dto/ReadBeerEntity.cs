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

        public int BeerKindID { get; set; }

        public string BeerKindName { get; set; }
        
        public int TradeMarkID { get; set; }

        public string TradeMarkName { get; set; }

        public string TradeMarkSpecification { get; set; }
    }
}
