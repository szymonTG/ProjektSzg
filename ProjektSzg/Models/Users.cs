namespace ProjektSzg.Models
{
    public class Users
    {
        public int userId { get; set; }
        public string firstName { get; set; }

        public string surname { get; set; }

        public int telNumber { get; set; }

        public ICollection<BookRentals>? BookRentals { get; set; }

    }
}
