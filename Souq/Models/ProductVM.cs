using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Souq.Models
{
    public class ProductVM
    {
        [Required]
        [Display(Name="Category Name")]
        [MinLength(10)]
        public string CatName { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        [MaxLength(20)]
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductQty { get; set; }
    }
}
