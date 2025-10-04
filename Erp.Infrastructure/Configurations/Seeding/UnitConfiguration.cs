

namespace Erp.Infrastructure.Configurations.Seeding
{
    internal class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("Units", "Seeding");
            builder.Property(u => u.Id).ValueGeneratedNever();
            builder.HasIndex(u => u.Name). IsUnique();
            builder.Property(pm => pm.Name).IsRequired().HasMaxLength(256);
            builder.Property(u => u.Quantity).
                HasDefaultValue(1).
                HasColumnType("decimal(18,2)");
            builder.HasCheckConstraint( "CK_Unit_Quantity", "Quantity >= 1 AND Quantity <= " + double.MaxValue);
        }
    }
}
