using System.ComponentModel.DataAnnotations;

namespace WebAPIPractical.Model
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage ="User name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        //public bool IsDeleted { get; set; }
    }
}
