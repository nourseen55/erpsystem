
namespace Erp.Infrastructure.Configurations.Purchasing
{
    internal class PurchaseInvoiceItemConfiguration : IEntityTypeConfiguration<PurchaseInvoiceItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoiceItem> builder)
        {
            builder.ToTable("PurchaseInvoiceItems", "Sales");
            builder.Property(e => e.Quantity).IsRequired().HasDefaultValue(1);
            builder.Property(e => e.UnitPrice).IsRequired().HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.Total).IsRequired().HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.HasOne(p => p.Product).
            WithMany(p => p.PurchaseInvoicesItems).
            HasForeignKey(p => p.ProductId).
            OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Store).
            WithMany(p => p.PurchaseInvoicesItems).
            HasForeignKey(p => p.StoreId).
            OnDelete(DeleteBehavior.Restrict);

            builder.HasCheckConstraint("CK_ PurchaseInvoiceItem _Quantity", "Quantity > 0");
            builder.HasCheckConstraint("CK  PurchaseInvoiceItem UnitPrice", "UnitPrice >= 8");
            builder.HasCheckConstraint("CK_ PurchaseInvoiceItem_Total", "Total >= 8");
        }
    }
}
