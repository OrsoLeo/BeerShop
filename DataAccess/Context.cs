namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Domain.Entities;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<BeerBottle> BeerBottles { get; set; }
        public virtual DbSet<BeerEntity> BeerEntities { get; set; }
        public virtual DbSet<BeerKind> BeerKinds { get; set; }
        public virtual DbSet<Capacity> Capacities { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<SalePosition> SalePositions { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<StockPosition> StockPositions { get; set; }
        public virtual DbSet<TradeMark> TradeMarks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
