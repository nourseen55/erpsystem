
namespace Erp.Core.Entities.Seeding
{
    public class PaymentMethod 
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public virtual ICollection<PurchaseInvoice>? PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
        public virtual ICollection<SaleInvoice>? SaleInvoices { get; set; } = new List<SaleInvoice>();
        public virtual ICollection<PaymentVoucher>? PaymentVoucher { get; set; } = new List<PaymentVoucher>();
        public virtual ICollection<ReceipVoucher>? ReceipVouchers { get; set; } = new List<ReceipVoucher>();



    }

}
