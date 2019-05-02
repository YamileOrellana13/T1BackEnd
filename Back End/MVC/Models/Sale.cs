namespace MVC.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        [Required]
        [Display(Name = "Sale Date")]
        public DateTime Date { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}