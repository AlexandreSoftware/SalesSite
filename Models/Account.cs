using System.ComponentModel.DataAnnotations;

namespace SalesSite.Models
{
    public class Account
    {
        public int id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; internal set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "{0} is required")]
        [Display(Name = "User Name")]
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Is Required")]

        public string Email;
        [Required(AllowEmptyStrings =false,ErrorMessage = "{0} is required")]
        [Range(7, 15, ErrorMessage = "{0} must be from {1} to {2} characters")]
        public string Password { get; set; }
    }
}