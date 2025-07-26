using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Book name is required.")]
        [StringLength(100)]
        [DisplayName("Book Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Author name is required.")]
        [StringLength(100)]
        public string? Author { get; set; }
        [Required(ErrorMessage = "Book summaray is required.")]
        [StringLength(200)]
        [DisplayName("Book Summary")]
        public string? Summary { get; set; }
        [Required(ErrorMessage = "Book price is required.")]
        [DataType(DataType.Currency, ErrorMessage = "Invalid price format.")]
        [Range(1, 100000000, ErrorMessage = "Book price must be greater than 0")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Published date is required.")]
        [DataType(DataType.Date)]
        [DisplayName("Published Date")]
        public DateTime PublishedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = null;
    }
}
