
namespace Erp.Core.Entities.Purchasing
{
    //Accounting
    public class PaymentVoucher
    {
        public int Id { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime Date { get; set; }
        public DateTime SystemDate { get; set; }
        public string? AttachmentPath { get; set; }
        public int BranchId { get; set; }
        [ForeignKey(nameof( BranchId))]
        public virtual Branch? Branch { get; set; }
        public int PaymentMethodId { get; set; }
        [ForeignKey(nameof (PaymentMethodId))]
        public virtual PaymentMethod? PaymentMethod {get; set; }
        public int SupplierId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier? Supplier { get; set; }
        public string CreatedByUserId { get; set; } = null!;
        [ForeignKey(nameof(CreatedByUserId))]
        public virtual Employee? Employee { get; set; }
    }

}
