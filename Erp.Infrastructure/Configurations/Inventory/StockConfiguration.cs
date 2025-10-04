

namespace Erp.Infrastructure.Configurations.Inventory
{
    internal class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("Stocks", "Inventory");
            builder.HasOne(s => s.Product)
             .WithMany(s => s.Stocks)
             .HasForeignKey(s => s.ProductId)
             .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.Store)
             .WithMany(s => s.Stocks)
             .HasForeignKey(s => s.StoreId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.Property(s => s.Quantity).IsRequired().HasDefaultValue(1);
            builder.HasCheckConstraint("CK_Stock_Quantity", "Quantity >= 1 AND Quantity <= " + double.MaxValue);

        }
    }
}
