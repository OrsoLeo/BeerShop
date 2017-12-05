namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalePosition
    {
        public int ID { get; set; }

        public int? SaleId { get; set; }

        public int BeerBottleId { get; set; }

        public int BottleCount { get; set; }

        public decimal Summ { get; set; }

        public virtual BeerBottle BeerBottle { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
