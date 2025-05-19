using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    [PrimaryKey("EmployeeID")]
    internal class Employee
    {
        public long EmployeeID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? Gender { get; set; }

        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        public bool Status { get; set; }

        [StringLength(6)]
        public string Password { get; set; }

        public byte RoleID { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
