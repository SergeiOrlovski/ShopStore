namespace ShopStore.Repository.DbContext
{
    using System.Data.Entity;

    public partial class ShopDb : DbContext
    {
        public ShopDb()
            : base("name=ShopDbContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Shop)
                .HasForeignKey(e => e.Shop_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
