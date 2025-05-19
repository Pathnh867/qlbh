using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    [PrimaryKey("OrderDetailID")]
    internal class OrderDetail
    {
        public long OrderDetailID { get; set; }

        public long OrderID { get; set; }

        public long ProductID { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
