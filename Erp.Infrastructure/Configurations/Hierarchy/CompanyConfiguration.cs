


namespace Erp.Infrastructure.Configurations.Hierarchy
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies", "Hierarchy");
            builder.HasIndex(x=>x.Name).IsUnique();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(256);
            builder.Property(c => c.Activity).IsRequired().HasMaxLength(256);
            builder.Property(c => c.TaxNumber).IsRequired(). HasMaxLength(50);
            builder.Property(c => c.RecordNumber).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Code).IsRequired(). HasMaxLength(50);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(30);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(256);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(450);
            builder.Property(c => c.Logo).IsRequired().HasMaxLength(450);
            builder.Property(c => c.Seal).IsRequired().HasMaxLength(450);
            //builder.Property(c => c.IsActive).HasDefaultValue(true);
        }
    }
}
