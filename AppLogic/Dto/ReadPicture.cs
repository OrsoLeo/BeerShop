using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.Dto
{
    public class ReadPicture
    {
        public int ID { get; set; }

        public string Path { get; set; }

        public ReadBeerBottle BeerBottle { get; set; }
    }
}
