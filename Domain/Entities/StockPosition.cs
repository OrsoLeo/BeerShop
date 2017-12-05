namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StockPosition
    {
        public int ID { get; set; }

        public int BeerBottleId { get; set; }

        public int BottleCount { get; set; }

        public virtual BeerBottle BeerBottle { get; set; }
    }
}
