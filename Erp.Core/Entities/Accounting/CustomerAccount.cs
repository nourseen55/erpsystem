

namespace Erp.Core.Entities.Accounting
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; } = null!;
        public decimal? Creditor { get; set; }
        public decimal? Debtor { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customer { get; set; }
        }

}
