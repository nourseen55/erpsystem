using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.Core.Entities.Hierarchy
{
    public class Department : BaseModel
    {
        public string Name { get; set; } = null!;
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch? Branch { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; } = new List<Employee>();

    }

}
