using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoCreate
{
    public class CreateBeerEntity
    {
        public string Name { get; set; }

        public double Alcohol { get; set; }

        public double Breadness { get; set; }
        
        public int BeerKindId { get; set; }

        public int TradeMarkId { get; set; }
    }
}
