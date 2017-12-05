using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoCreate
{
    public class CreateSalePosition
    {
        public int BottleCount { get; set; }

        public decimal Summ { get; set; }

        public int BeerBottleId { get; set; }

        public int SaleId { get; set; }
    }
}
