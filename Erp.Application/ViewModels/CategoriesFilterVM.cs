

namespace Erp.Application.ViewModels
{
    public class CategoriesFilterVM
    {
        public string Name { get; set; }
        public string Search { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public bool? IsActive { get; set; }
        public List<SelectListItem> Brands { get; set; } = new();
        public List<SelectListItem> StatusTypes { get; set; } = new();
        public List<bool?> IsActiveValues { get; set; } = new();


    }
}
