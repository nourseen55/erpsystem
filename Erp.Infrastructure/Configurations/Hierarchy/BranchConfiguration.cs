
namespace Erp.Infrastructure.Configurations.Hierarchy
{
    internal class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches", "Hierarchy");
            builder.HasIndex(b=>b.Name). IsUnique();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(256);
            builder.Property(b => b.Address).IsRequired().HasMaxLength(450);
            builder.Property(b => b.PhoneNumber).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Email).IsRequired().HasMaxLength(150);
        }
    }
}
