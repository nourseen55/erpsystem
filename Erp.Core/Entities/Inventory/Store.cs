
namespace Erp.Core.Entities.Inventory
{
    public class Store 
    {
        public bool IsActive { get; set; } = true;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Email{get; set; }
        public string? Address { get; set; }
        public string? AdministratorId { get; set; }
        [ForeignKey(nameof (AdministratorId))]
        public virtual Employee? Administrator { get; set; }
        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Brand? Branch { get; set; }
        public virtual ICollection<Stock>? Stocks { get; set; } = new List<Stock>();
        public virtual ICollection<StoreHistory>? StoreHistories { get; set; } = new List<StoreHistory>();
        public virtual ICollection<SaleInvoice>? SaleInvoices { get; set; } = new List<SaleInvoice>();
        public virtual ICollection<PurchaseInvoice>? PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
        public virtual ICollection<SaleInvoiceItem>? SaleInvoicesItems { get; set; } = new List<SaleInvoiceItem>();
        public virtual ICollection<PurchaseInvoiceItem>? PurchaseInvoicesItems { get; set; } = new List<PurchaseInvoiceItem>();



    }

}
