using System.ComponentModel.DataAnnotations;

namespace WebAPIPractical.Model
{
    public class Article
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage ="Blog title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Blog description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Created by is required")]
        public int CreatedBy { get; set; }

    }
}
