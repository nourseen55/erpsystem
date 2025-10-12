

namespace Erp.Infrastructure.Configurations.Accounting
{
    internal class SupplierAccountConfiguration : IEntityTypeConfiguration<SupplierAccount>
    {
        public void Configure(EntityTypeBuilder<SupplierAccount> builder)
        {
            builder.ToTable("SupplierAccounts", "Accounting");
            builder.Property(e => e.ItemType).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Creditor).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.Debtor).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.Total).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.HasOne(p => p.Supplier)
            .WithMany(p => p.SupplierAccounts)
            .HasForeignKey(p => p.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasCheckConstraint("CK_SupplierAccount_Creditor", "Creditor>= 0");
            builder.HasCheckConstraint("CK_SupplierAccount_Debtor", "Debtor >= 0");
            builder.HasCheckConstraint("CK_SupplierAccount_Total", "Total >= 0 ");
        }
    }
}
