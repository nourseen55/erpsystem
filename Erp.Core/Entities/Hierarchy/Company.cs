namespace Erp.Core.Entities.Hierarchy
{
    public class Company : BaseModel
    {
        public required string Name { get; set; }
        public string Activity { get; set; } = null!;
        public string TaxNumber { get; set; } = null!;
        public string RecordNumber { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Seal { get; set; } = null!;
        public string Logo { get; set; } = null!;
    }

}
