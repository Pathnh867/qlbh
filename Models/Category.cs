using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    [PrimaryKey("CategoryID")]
    internal class Category
    {
        public int CategoryID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int Order { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
