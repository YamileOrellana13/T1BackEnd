

using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        public double Price { get; set; }

    }
}
