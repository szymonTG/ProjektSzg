
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjektSzg.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; }
        [Required(ErrorMessage = "The user first name is required!")]
        [MaxLength(100)]
        [MinLength(1)]
        [DisplayName("User name")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "The user surname name is required!")]
        [MaxLength(100)]
        [MinLength(1)]
        [DisplayName("User surname")]
        public string surname { get; set; }
        [Required(ErrorMessage = "The user telephone number is required!")]
        [MaxLength(9)]
        [MinLength(9)]
        [DisplayName("User telephone number")]
        public int telNumber { get; set; }

        public ICollection<BookRentals>? BookRentals { get; set; }

    }
}
