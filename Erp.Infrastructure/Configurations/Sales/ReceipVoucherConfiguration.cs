
namespace Erp.Infrastructure.Configurations.Sales
{
    internal class ReceipVoucherConfiguration : IEntityTypeConfiguration<ReceipVoucher>
    {
        public void Configure(EntityTypeBuilder<ReceipVoucher> builder)
        {
            builder.ToTable("ReceipVouchers", "Finance");
            builder.Property(e => e.AmountPaid).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(p => p.Employee).
                WithMany(p => p.ReceipVouchers)
                .HasForeignKey(p => p.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
           builder.HasOne(p => p.Customer).
            WithMany(p => p.ReceipVouchers)
            .HasForeignKey(p => p.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
