
namespace Erp.Core.Entities.Accounting
{
    public class SupplierAccount
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; } = null!;
        public decimal? Creditor { get; set; }
        public decimal? Debtor { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier? Supplier { get; set; }
    }

}
