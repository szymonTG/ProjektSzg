

namespace ProjektSzg.Models
{
    public class BookRentals
    {
        public int rentalId { get; set; }
        
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }

        public int userId { get; set; }
        public Users? Users { get; set; }
        public int bookId { get; set; }
        public Books? Books { get; set; }

    }
}
