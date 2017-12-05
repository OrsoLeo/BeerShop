using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Dto
{
    public class ReadSale
    {
        public int ID { get; set; }

        public decimal Summ { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
