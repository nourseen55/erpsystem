
namespace Erp.Core.Entities.Inventory
{
    public class StockHistory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Event { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public int StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public virtual Stock? Stock { get; set; }
        public string CreatedByUserId { get; set; } = null!;
        [ForeignKey(nameof(CreatedByUserId))]
        public virtual Employee? Employee { get; set; }


    }

}
