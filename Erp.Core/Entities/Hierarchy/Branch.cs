

namespace Erp.Core.Entities.Hierarchy
{
    public class Branch : BaseModel {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsMainBranch { get; set; }
        public int CurrencyId { get; set; }
        [ForeignKey("CurrencyId")]

        public virtual Currency? Currency { get; set; }
        public virtual ICollection<Customer>? Customers { get; set; } = new List<Customer>();
        public virtual ICollection<Supplier>? Suppliers { get; set; } = new List<Supplier>();
                
        public virtual ICollection<Department>? Departments { get; set; } = new List<Department>();
        public virtual ICollection<Brand>? Brands { get; set; } = new List<Brand>();
        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();
        public virtual ICollection<SaleInvoice>? SaleInvoices { get; set; } = new List<SaleInvoice>();
        public virtual ICollection<PurchaseInvoice>? PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
        public virtual ICollection<PaymentVoucher>? PaymentVoucher { get; set; } = new List<PaymentVoucher>();
        public virtual ICollection<ReceipVoucher>? ReceipVouchers { get; set; } = new List<ReceipVoucher>();

    }

}
