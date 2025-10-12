
namespace Erp.Web.Extensions
{
    public static class FormCollectionExtensions
    {
        public static RequestFormDto ToRequestFormDto(this IFormCollection form)
        {
            int.TryParse(form["draw"], out var draw);
            int.TryParse(form["start"], out var start);
            int.TryParse(form["length"], out var length);

            int pageNumber = 1;
            if (length > 0) pageNumber = (start / length) + 1;

            var dir = form["order[0][dir]"].ToString();
            var orderColIndex = form["order[0][column]"].ToString();

            var sortColumn = "Id";
            if (!string.IsNullOrEmpty(orderColIndex))
            {
                var key = $"columns[{orderColIndex}][data]";
                sortColumn = form[key].ToString() ?? "Id";
            }


            return new RequestFormDto
            {
                Draw = draw,
                Start = start,
                Length = length,
                SortColumn = string.IsNullOrWhiteSpace(sortColumn) ? "Id" : sortColumn,
                Dir = string.IsNullOrWhiteSpace(dir) ? "asc" : dir
            };
        }
    }
}
