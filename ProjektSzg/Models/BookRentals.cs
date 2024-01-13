

using System.ComponentModel.DataAnnotations;

namespace ProjektSzg.Models
{
    public class BookRentals
    {
        [Key]
        public int rentalId { get; set; }
        [Required(ErrorMessage = "The rental start date is required!")]
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        [Required(ErrorMessage = "The user id is required!")]
        public int userId { get; set; }
        public Users? Users { get; set; }
        [Required(ErrorMessage = "The book id is required!")]
        public int bookId { get; set; }
        public Books? Books { get; set; }

    }
}
