using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    [PrimaryKey("CustomerID")]
    internal class Customer
    {
        public long CustomerID { get; set; } //bigint, identity(1,1), PK

        [StringLength(100)]
        public string Name { get; set; } //nvarchar(100)

        public bool? Gender { get; set; } //bit, null

        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; } //nchar(10)

        [StringLength(100)]
        public string? Email { get; set; } //nvarchar(100), null

        public bool Status { get; set; } //bit, not null

        //Mỗi khách hàng đặt nhiều đơn hàng
        public virtual ICollection<Order> Orders { get; set; }
    }
}
