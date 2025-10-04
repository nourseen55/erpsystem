

namespace Erp.Infrastructure.Configurations.Purchasing
{
    internal class PaymentVoucherConfiguration : IEntityTypeConfiguration<PaymentVoucher>
    {
        public void Configure(EntityTypeBuilder<PaymentVoucher> builder)
        {
            builder.ToTable("Payment Vouchers", "Finance");
            builder.Property(e => e.AmountPaid).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(p => p.Employee).
                WithMany(p => p.PaymentVoucher)
                .HasForeignKey(p => p.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
                            builder.HasOne(p => p.Supplier).
                WithMany(p => p.PaymentVoucher)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
