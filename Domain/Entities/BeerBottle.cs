namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BeerBottle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeerBottle()
        {
            Pictures = new HashSet<Picture>();
            SalePositions = new HashSet<SalePosition>();
            StockPositions = new HashSet<StockPosition>();
        }

        public int ID { get; set; }

        public DateTime DateOfSpill { get; set; }

        public decimal Price { get; set; }

        public int? BeerEntityId { get; set; }

        public int? CapacityId { get; set; }

        public virtual BeerEntity BeerEntity { get; set; }

        public virtual Capacity Capacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Picture> Pictures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalePosition> SalePositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockPosition> StockPositions { get; set; }
    }
}
