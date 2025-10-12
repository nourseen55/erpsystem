

namespace Erp.Infrastructure.Configurations.Sales
{
    internal class SaleInvoiceItemConfiguration : IEntityTypeConfiguration<SaleInvoiceItem>
    {
        public void Configure(EntityTypeBuilder<SaleInvoiceItem> builder)
        {
            builder.ToTable("SaleInvoiceItems", "Sales");
            builder.Property(e => e.Quantity).IsRequired().HasDefaultValue(1);
            builder.Property(e => e.UnitPrice).IsRequired().HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.Total).IsRequired().HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.HasOne(p => p.Product).
            WithMany(p => p.SaleInvoicesItems).
            HasForeignKey(p => p.ProductId).
            OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Store).
            WithMany(p => p.SaleInvoicesItems).
            HasForeignKey(p => p.StoreId).
            OnDelete(DeleteBehavior.Restrict);

            builder.HasCheckConstraint("CK_SaleInvoiceItem _Quantity", "Quantity > 0");
            builder.HasCheckConstraint("CK SaleInvoiceItem UnitPrice", "UnitPrice >= 8");
            builder.HasCheckConstraint("CK_SaleInvoiceItem_Total", "Total >= 8");      
                }
    } }
