using System.ComponentModel.DataAnnotations;

namespace PosApp.DTOs
{
    public class CheckoutFormDTO
    {
        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string CustomerName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? CustomerEmail { get; set; }
    }
}