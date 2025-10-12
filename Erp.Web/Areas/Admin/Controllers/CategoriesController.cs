

namespace Erp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesBL _categoriesBL;

        public CategoriesController(ICategoriesBL categoriesBL)
        {
            _categoriesBL = categoriesBL;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _categoriesBL.PrepareModelAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetCategories(CategoriesFilterVM filterVM)
        {
            try
            {
                var model = Request.Form.ToRequestFormDto();

                var result = _categoriesBL.GetAllCategories(filterVM);

                result = result.OrderBy($"{model.SortColumn} {model.Dir}");

                var recordsTotal = await result.CountAsync();
                var data = await result.Skip(model.Start).Take(model.Length).ToListAsync();

                return Ok(new
                {
                    recordsFiltered = recordsTotal,
                    recordsTotal,
                    data
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

    }

}

