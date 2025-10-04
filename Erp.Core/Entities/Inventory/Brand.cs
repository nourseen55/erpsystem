
namespace Erp.Core.Entities.Inventory
{
    //end
    public class Brand : BaseModel
    {
        public string Name { get; set; }=null!;
        public string? ImagePath { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch? Branch { get; set; }
        public virtual ICollection<Category>? Categories { get; set; } = new List<Category>();
        public virtual ICollection<SaleInvoice>? SaleInvoices { get; set; } = new List<SaleInvoice>();
        public virtual ICollection<PurchaseInvoice>? PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
        
    }

}
