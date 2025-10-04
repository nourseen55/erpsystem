
namespace Erp.Core.Entities.Sales
{
    public class SaleInvoice
    {
        public int Id { get; set; }

        public string SaleInvoiceKey { get; set; } = null!;

        public DateTime SaleInvoiceDate { get; set; }

        public DateTime SystemDate { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public  virtual Customer? Customer { get; set; }
        public string EmployeeId { get; set; } = null!;
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }
        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Brand? Branch { get; set; }

        public int PaymentMethodId { get; set; }
        [ForeignKey(nameof(PaymentMethodId))]
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public decimal BeforeDiscount { get; set; }  
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public required string TotalWritten { get; set; }
        public virtual ICollection<SaleInvoiceItem>? SaleInvoicesItems { get; set; } = new List<SaleInvoiceItem>();


    }

}
