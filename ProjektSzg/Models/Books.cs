namespace ProjektSzg.Models
{
    public class Books
    {
        public int bookId { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string isbn { get; set; }

        public ICollection<BookRentals>? BookRentals { get; set; }

    }
}
