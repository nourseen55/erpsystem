
namespace Erp.Infrastructure.Configurations.Inventory
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands", "Inventory");
            builder.HasIndex(e => new { e.Name, e.BranchId }). IsUnique();
            builder.Property(e => e.ImagePath).IsRequired().HasMaxLength(450);
            builder.Property(b => b.ImagePath)
            .HasDefaultValue("/Images/Users/DefaultImageUser.png");
        }
    }
}
