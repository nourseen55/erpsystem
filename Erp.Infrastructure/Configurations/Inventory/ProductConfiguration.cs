

namespace Erp.Infrastructure.Configurations.Inventory
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "Inventory");
            builder.HasIndex(e => new { e.Name, e.BranchId }).IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Price).IsRequired().HasDefaultValue(0);
            builder.HasOne(p => p.Category)
            .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict); 
            builder.HasCheckConstraint ("CK_Product_Price", "Price >= 1 AND Price <= " + double.MaxValue);
        }
    }
}
