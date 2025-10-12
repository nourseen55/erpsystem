

namespace Erp.Infrastructure.Configurations.Purchasing
{
    internal class PurchaseInvoiceConfiguration : IEntityTypeConfiguration<PurchaseInvoice>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoice> builder)
        {
            builder.ToTable("PurchaseInvoices", "Sales");
            builder.Property(e => e.PurchaseInvoiceKey).IsRequired().HasMaxLength(256);
            builder.Property(e => e.PurchaseInvoiceDate).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.SystemDate).IsRequired().HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.BeforeDiscount).HasColumnType("decimal(18,2)").HasDefaultValue(0m); builder.Property(e => e.Discount).HasColumnType("decimal(18,2)").HasDefaultValue(0);
            builder.Property(e => e.TotalAmount).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.TotalWritten).IsRequired().HasMaxLength(500);

            builder.HasOne(p => p.Supplier).
                WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.PaymentMethod)
                            .WithMany(p => p.PurchaseInvoices).
                HasForeignKey(p => p.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Employee).
                WithMany(p => p.PurchaseInvoices).
                HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Branch)
                  .WithMany(p => p.PurchaseInvoices).HasForeignKey(p => p.BranchId).
                           OnDelete(DeleteBehavior.Restrict);
        }
    }
}
