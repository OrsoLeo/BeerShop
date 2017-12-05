using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoCreate
{
    public class CreateBeerBottle
    {
        public DateTime DateOfSpill { get; set; }

        public decimal Price { get; set; }
        
        public int BeerEntityId { get; set; }

        public int CapacityId { get; set; }
    }
}
