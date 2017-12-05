namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BeerEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeerEntity()
        {
            BeerBottles = new HashSet<BeerBottle>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public double Alcohol { get; set; }

        public double Breadness { get; set; }

        public int? BeerKindId { get; set; }

        public int? TradeMarkId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeerBottle> BeerBottles { get; set; }

        public virtual BeerKind BeerKind { get; set; }

        public virtual TradeMark TradeMark { get; set; }
    }
}
