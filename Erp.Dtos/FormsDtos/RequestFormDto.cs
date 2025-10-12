

namespace Erp.Dtos.FormsDtos
{
    public record RequestFormDto
    {
        public int Draw { get; init; }     
        public int Start { get; init; }  
        public int Length { get; init; }    
        public string Search { get; init; } = string.Empty;
        public string SortColumn { get; init; } = "Id";    
        public string Dir { get; init; } = "asc";       
    }
}
