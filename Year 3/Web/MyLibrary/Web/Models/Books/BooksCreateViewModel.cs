using System.ComponentModel.DataAnnotations;

namespace Web.Models.Books
{
    public class BooksCreateViewModel
    {
        [Required]
        [MaxLength(80, ErrorMessage = "Author name cannot be longer than 80 characters")]
        public string Author { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "Title length cannot be more than 80 characters")]
        public string Title { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Negative values are not accepted")]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$|^\d{13}$", ErrorMessage = "ISBN should be either 10 or 13 characters long")]
        public string ISBN { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Negative values or 0 are not accepted")]
        public int Pages { get; set; }
    }
}
