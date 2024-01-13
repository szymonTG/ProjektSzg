

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjektSzg.Models
{
    public class BookRentals
    {
        [Key]
        public int rentalId { get; set; }
        [Required(ErrorMessage = "The rental start date is required!")]
        [DisplayName("Rental date start")]
        public DateTime startDate { get; set; }
        [DisplayName("Rental date end")]
        public DateTime? endDate { get; set; }
        [Required(ErrorMessage = "The user id is required!")]
        [DisplayName("Rental User Id")]
        public int userId { get; set; }
        public Users? Users { get; set; }
        [Required(ErrorMessage = "The book id is required!")]
        [DisplayName("Rental Book Id")]
        public int bookId { get; set; }
        public Books? Books { get; set; }

    }
}
