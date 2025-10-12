namespace Erp.Core.Entities.Hierarchy
{
    public class BrandTest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public virtual ICollection<Category>? Categories { get;set; }=new List<Category>();
    }
}