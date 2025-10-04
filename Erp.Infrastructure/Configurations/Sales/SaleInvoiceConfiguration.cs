namespace Erp.Infrastructure.Configurations.Sales
{
    internal class SaleInvoiceConfiguration : IEntityTypeConfiguration<SaleInvoice>
    {
        public void Configure(EntityTypeBuilder<SaleInvoice> builder)
        {
            builder.ToTable("SaleInvoices", "Sales");
            builder.Property(e => e.SaleInvoiceKey).IsRequired().HasMaxLength(256);
            builder.Property(e => e.SaleInvoiceDate).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.SystemDate).IsRequired().HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.BeforeDiscount).HasColumnType("decimal(18,2)").HasDefaultValue(0); builder.Property(e => e.Discount).HasColumnType("decimal(18,2)").HasDefaultValue(0);
            builder.Property(e => e.TotalAmount) .HasColumnType("decimal(18,2)").HasDefaultValue(0);
            builder.Property(e => e.TotalWritten).IsRequired().HasMaxLength(500);

            builder.HasOne(p => p.Customer).
                WithMany(p => p.SaleInvoices)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.PaymentMethod)
                            .WithMany(p => p.SaleInvoices).
                HasForeignKey(p => p.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Employee).
                WithMany(p => p.SaleInvoices).
                HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Branch)
                  .WithMany(p => p.SaleInvoices).HasForeignKey(p => p.BranchId).
                           OnDelete(DeleteBehavior.Restrict);
        }
    }
}
