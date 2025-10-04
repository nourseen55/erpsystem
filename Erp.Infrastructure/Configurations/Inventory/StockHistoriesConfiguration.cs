
namespace Erp.Infrastructure.Configurations.Inventory
{
    internal class StockHistoriesConfiguration : IEntityTypeConfiguration<StockHistory>
    {
        public void Configure(EntityTypeBuilder<StockHistory> builder)
        {
            builder.ToTable("StockHistories", "Inventory");
            builder.HasOne(s=>s.Stock).WithMany(s=>s.StockHistories)
                .HasForeignKey(s=>s.StockId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
