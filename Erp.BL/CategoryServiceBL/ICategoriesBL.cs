


namespace Erp.BL.CategoryServiceBL
{
    public interface ICategoriesBL
    {
        Task<CategoriesFilterVM> PrepareModelAsync();
        public IQueryable<CategoryDto> GetAllCategories(CategoriesFilterVM filterVM);

    }
}
