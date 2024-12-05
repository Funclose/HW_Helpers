namespace HW_Helpers.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Age { get; set; }

        public string? Error { get; set; }
    }
}
