namespace my_books.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }
    }
}
