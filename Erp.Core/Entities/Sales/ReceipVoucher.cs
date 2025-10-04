﻿

namespace Erp.Core.Entities.Sales
{
    public class ReceipVoucher
    {
        public int Id { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime Date { get; set; }
        public DateTime SystemDate { get; set; }
        public string? AttachmentPath { get; set; }
        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public int PaymentMethodId { get; set; }
        [ForeignKey(nameof(PaymentMethodId))]
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public  virtual Customer? Customer { get; set; }
        public string CreatedByUserId { get; set; } = null!;
        [ForeignKey(nameof(CreatedByUserId))]
        public virtual Employee? Employee { get; set; }
    }

}
