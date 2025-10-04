
namespace Erp.Core.Entities.Inventory
{
    public class StoreHistory
    {
        public int Id{ get; set; }
        public string Name { get; set; } = null!;
        public string Event { get; set; } = null!;
        public DateTime Date { get; set; }= DateTime.UtcNow;
        public string CreatedByUserId { get; set; } = null!;
        [ForeignKey(nameof (CreatedByUserId))]      
        public virtual Employee? Employee { get; set; }

        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public virtual Store? Store { get; set; }


    }

}
