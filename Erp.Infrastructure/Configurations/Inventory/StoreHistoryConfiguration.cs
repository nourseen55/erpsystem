

namespace Erp.Infrastructure.Configurations.Inventory
{
    internal class StoreHistoryConfiguration : IEntityTypeConfiguration<StoreHistory>
    {
        public void Configure(EntityTypeBuilder<StoreHistory> builder)
        {
            builder.ToTable("StoreHistories", "Inventory");

            builder.HasOne(s=>s.Store)
                .WithMany(s=>s.StoreHistories)
                .HasForeignKey(s=>s.StoreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
