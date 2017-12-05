namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Picture
    {
        public int ID { get; set; }

        public string Path { get; set; }

        public int BeerBottleId { get; set; }

        public virtual BeerBottle BeerBottle { get; set; }
    }
}
