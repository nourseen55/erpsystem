
namespace Erp.Infrastructure.Configurations.Accounting
{
    internal class CustomerAccountConfiguration : IEntityTypeConfiguration<CustomerAccount>
    {
        public void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            builder.ToTable("CustomerAccounts", "Accounting");
            builder.Property(e => e.ItemType).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Creditor).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.Debtor).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.Property(e => e.Total).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            builder.HasOne(p => p.Customer)
            .WithMany(p => p.CustomerAccounts)
            .HasForeignKey(p => p.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasCheckConstraint("CK_CustomerAccount_Creditor", "Creditor>= 0");
            builder.HasCheckConstraint( "CK_CustomerAccount_Debtor", "Debtor >= 0");
            builder.HasCheckConstraint("CK_CustomerAccount_Total", "Total >= 0 ");
        }
    }
}
