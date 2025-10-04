
namespace Erp.Core.Entities.Sales
{
    public class SaleInvoiceItem
    {
        public int Id { get; set; }

        public int SaleInvoiceId { get; set; }
        [ForeignKey(nameof(SaleInvoiceId))]
        public SaleInvoice? SaleInvoice { get; set; }

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product? Product { get; set; }

        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public virtual Store? Store { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }

}
