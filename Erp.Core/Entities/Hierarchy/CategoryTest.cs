

namespace Erp.Core.Entities.Hierarchy
{
    public class CategoryTest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        [ForeignKey(nameof(CategoryTest.Id))]
        public int BrandTestId { get; set; }
        public virtual BrandTest? BrandTest { get; set; }
    }
}
