using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Dto
{
    public class ReadBeerBottle
    {
        public int ID { get; set; }

        public DateTime DateOfSpill { get; set; }

        public decimal Price { get; set; }
        
        public ReadBeerEntity BeerEntity { get; set; }

        public ReadCapacity Capacity { get; set; }
    }
}
