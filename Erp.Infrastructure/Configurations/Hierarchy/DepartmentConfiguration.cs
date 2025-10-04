

namespace Erp.Infrastructure.Configurations.Hierarchy
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "Hierarchy");
            builder.HasIndex(d => new{ d.Name,d.BranchId}).IsUnique();
            builder.Property(d => d.Name).IsRequired().HasMaxLength(256);

        }
    }
}
