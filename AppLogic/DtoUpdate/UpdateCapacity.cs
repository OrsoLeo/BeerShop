using AppLogic.DtoCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.DtoUpdate
{
    public class UpdateCapacity : CreateCapacity
    {
        public int ID { get; set; }
    }
}
