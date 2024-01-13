using System.ComponentModel.DataAnnotations;

namespace ProjektSzg.Models
{
    public class Books
    {
        [Key]
        public int bookId { get; set; }
        [Required (ErrorMessage ="The title is required!")]
        [MaxLength(55)]
        [MinLength(1)]
        public string title { get; set; }
        [Required(ErrorMessage = "The author is required!")]
        [MaxLength(75)]
        [MinLength(10)]
        public string author { get; set; }
        [Required(ErrorMessage = "The ISBN is required!")]
        [MaxLength(13)]
        [MinLength(13)]
        public string isbn { get; set; }

        public ICollection<BookRentals>? BookRentals { get; set; }

    }
}
