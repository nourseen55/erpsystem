

namespace Erp.Infrastructure.Configurations.Sales
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers", "Sales");
            builder.HasIndex(e => new { e.Name, e.BranchId }). IsUnique();
            builder.HasIndex(e => new { e.PhoneNumber, e.BranchId }). IsUnique();
            builder.HasIndex(e => new { e.Email, e.BranchId }). IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(256);
            builder.Property(e => e.PhoneNumber).IsRequired(). HasMaxLength(25);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
            builder.Property(e => e.FirstBalance).HasColumnType("decimal(18,2)").HasDefaultValue(0);
            builder.HasOne( p => p.Branch)
                .WithMany(p => p.Customers)
                .HasForeignKey(p => p.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
