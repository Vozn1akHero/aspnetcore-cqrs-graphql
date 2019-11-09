namespace librarygraphql.Commands
{
    public class CreateBookCommand
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }
    }
}