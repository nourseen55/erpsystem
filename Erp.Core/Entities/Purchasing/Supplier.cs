﻿

namespace Erp.Core.Entities.Purchasing
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public decimal? FirstBalance { get; set; } = 0;
        public int BranchId { get; set; }
        [ForeignKey(nameof (BranchId))]
        public virtual Branch? Branch { get; set; }
        public virtual ICollection<PurchaseInvoice>? PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
        public virtual ICollection<PaymentVoucher>? PaymentVoucher { get; set; } = new List<PaymentVoucher>();
        public virtual ICollection<SupplierAccount>? SupplierAccounts { get; set; } = new List<SupplierAccount>();



    }

}
