

namespace Erp.Core.Entities.Purchasing
{
    public class PurchaseInvoice
    {
        public int Id { get; set; }

        public string PurchaseInvoiceKey { get; set; } = null!;

        public DateTime PurchaseInvoiceDate { get; set; }

        public DateTime SystemDate { get; set; }

        public int SupplierId { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier? Supplier { get; set; }
        public string EmployeeId { get; set; } = null!;
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }
        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public int PaymentMethodId { get; set; }
        [ForeignKey(nameof(PaymentMethodId))]
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public decimal BeforeDiscount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public required string TotalWritten { get; set; }
        public virtual ICollection<PurchaseInvoiceItem>? PurchaseInvoicesItems { get; set; }= new List<PurchaseInvoiceItem>();

    }

}
