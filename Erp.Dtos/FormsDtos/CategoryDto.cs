

namespace Erp.Dtos.FormsDtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public bool IsActive { get; set; }
        public string Status => IsActive ? "مفعل" : "غير مفعل";
  
    }
}
