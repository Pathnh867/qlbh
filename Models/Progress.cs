using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    [PrimaryKey("ProgressID")]
    internal class Progress
    {
        public byte ProgressID { get; set; }

        [Column(TypeName = "nchar(15)")]
        public string Name { get; set; }
    }
}
