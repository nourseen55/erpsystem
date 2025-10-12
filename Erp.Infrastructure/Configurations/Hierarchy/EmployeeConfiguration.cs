
namespace Erp.Infrastructure.Configurations.Hierarchy
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //builder.ToTable("Employees", "Hierarchy");
            builder.HasIndex(e =>   e.Email). IsUnique();
            builder.HasIndex(e =>  e.PhoneNumber). IsUnique();
            builder.HasIndex(e => e.UserId). IsUnique();
            builder.Property(e => e.FullName).IsRequired().HasMaxLength(256);
            builder.Property(e => e.ImagePath).IsRequired().HasMaxLength(450);
            builder.Property(e => e.Signature).IsRequired().HasMaxLength(450);
            builder.HasCheckConstraint( "CK_Employee_IsActive", "IsActive IN (0,1)");
            builder.HasCheckConstraint( "CK_Employee_IsUser", "IsUser IN (0,1)");
        }
    }
}
