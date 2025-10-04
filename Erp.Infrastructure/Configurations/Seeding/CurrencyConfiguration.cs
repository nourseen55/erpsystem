


namespace Erp.Infrastructure.Configurations.Seeding
{
    internal class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currencies", "Seeding");
            builder.Property(c => c.Id).ValueGeneratedNever();
            builder.HasIndex(c => c.Name). IsUnique();
            builder.HasIndex(c => c.Code). IsUnique();
            builder.Property(pm => pm.Name).IsRequired().HasMaxLength(256);
            builder.Property(c => c.Code).
                HasMaxLength(10)
                .HasDefaultValue("EGP");
            builder.Property(c => c.IsActive).
                HasDefaultValue(true);
        }
    }
}
