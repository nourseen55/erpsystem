
namespace Erp.Core.Entities.Seeding
{
    public class Unit{
        public int Id { get; set; }

        public string Name { get; set; }=null!;
        public int Quantity { get; set; }
        public virtual ICollection<Store>? Stores { get; set; } = new List<Store>();
        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();

    }

}
