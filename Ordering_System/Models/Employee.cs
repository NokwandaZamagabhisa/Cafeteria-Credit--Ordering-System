using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ordering_System.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(20)]
        public string EmployeeNumber { get; set; } = "";


        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        [Column(TypeName = "Date")]
        public DateTime LastDepositMonth { get; set; }

        public virtual List<Employee> Employees { get; set; } = new List<Employee>(); //detailed list
    }
}
