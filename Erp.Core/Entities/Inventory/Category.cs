
namespace Erp.Core.Entities.Inventory
{
    public class Category : BaseModel
    {
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand? Brand { get; set; }
        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();

    }

}
