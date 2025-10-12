



namespace Erp.BL.CategoryServiceBL
{
    public class CategoriesBL:ICategoriesBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriesBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        

        public async Task<CategoriesFilterVM> PrepareModelAsync()
        {
            var brandsList = await _unitOfWork.Repository<BrandTest>()
                                              .GetAllQueryable(b => b.IsActive)
                                              .Select(b => new SelectListItem
                                              {
                                                  Text = b.Name,
                                                  Value = b.Id.ToString()
                                              })
                                              .ToListAsync();

            var statusTypes = new List<SelectListItem>
            {
                new SelectListItem { Text = "الكل", Value = "" },
                new SelectListItem { Text = "مفعل", Value = "true" },
                new SelectListItem { Text = "غير مفعل", Value = "false" }
            };

            return new CategoriesFilterVM
            {
                Brands = brandsList,
                StatusTypes = statusTypes
            };
        }
        public IQueryable<CategoryDto> GetAllCategories(CategoriesFilterVM filterVM)
        {
            var query = _unitOfWork.Repository<CategoryTest>().GetAllQueryable(c=>true);

            if (!string.IsNullOrWhiteSpace(filterVM.Name))
                query = query.Where(c => c.Name.Contains(filterVM.Name));

            if (filterVM.IsActiveValues != null && filterVM.IsActiveValues.Any())
                query = query.Where(c => filterVM.IsActiveValues.Contains(c.IsActive));

            if (filterVM.BrandId > 0)
                query = query.Where(c => c.BrandTestId == filterVM.BrandId);
            if (!string.IsNullOrEmpty(filterVM.Search))
            {
                string search = filterVM.Search.ToLower();
                query = query.Where(c =>
                    c.Name.ToLower().Contains(search) ||
                    (c.BrandTest != null && c.BrandTest.Name.ToLower().Contains(search)) 
                );
            }

            return query.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                BrandName = c.BrandTest != null ? c.BrandTest.Name : string.Empty,
                BrandId = c.BrandTestId,
                IsActive = c.IsActive, 
            });
        }
    }
}

