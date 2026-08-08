using System.ComponentModel.DataAnnotations;

namespace PosApp.DTOs
{
    public class AddToCartDTO
    {
        [Required]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a quantity.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
    }
}