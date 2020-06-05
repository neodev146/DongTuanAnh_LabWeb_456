using System.ComponentModel.DataAnnotations;

namespace DongTuanAnh_Lab_456.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set;  }
    }
}