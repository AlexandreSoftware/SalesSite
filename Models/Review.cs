using System.ComponentModel.DataAnnotations;

namespace SalesSite.Models
{
    public class Review
    {
        [Required(ErrorMessage = "{0} is required")]
        [Range(4,1000)]
        public string Message { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [Range(0, 5)]
        public int Rating { get; set; }
    }
}