

namespace Erp.Infrastructure.Configurations.Seeding
{
    internal class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("Payment Methods", "Seeding");
            builder.HasKey(pm => pm.Id);
            builder.Property(pm => pm.Id).ValueGeneratedNever();
            builder.HasIndex( p => p.Name).IsUnique();
            builder.Property(pm => pm.Name).IsRequired().HasMaxLength(256);

            builder.HasMany(pm => pm.SaleInvoices)
            .WithOne(pm => pm.PaymentMethod)
             .HasForeignKey(pm => pm.PaymentMethodId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(pm => pm.PurchaseInvoices)
            .WithOne(pm => pm.PaymentMethod)
             .HasForeignKey(pm => pm.PaymentMethodId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(pm => pm.PaymentVoucher)
            .WithOne(pm => pm.PaymentMethod)
            .HasForeignKey(pm => pm.PaymentMethodId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(pm => pm.ReceipVouchers)
            .WithOne(pm => pm.PaymentMethod)
            .HasForeignKey(pm => pm.PaymentMethodId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
