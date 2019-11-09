using System.Linq;
using System.Threading.Tasks;
using librarygraphql.Models;
using Microsoft.EntityFrameworkCore;

namespace librarygraphql.Commands.Handlers
{
    public class BookCommandHandler
    {
        private readonly LibraryContext _libraryContext;

        public BookCommandHandler(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        
        public async Task<Book> Handle(CreateBookCommand command)
        {
            var book = new Book
            {
                CategoryId = command.CategoryId,
                AuthorId = command.AuthorId,
                Title = command.Title,
                CountryId = command.CountryId,
                LanguageId = command.LanguageId,
                Description = command.Description,
                PublisherId = command.PublisherId
            };
            
            _libraryContext.Set<Book>().Add(book);
            await _libraryContext.SaveChangesAsync();

            return _libraryContext.Set<Book>()
                .Include(e => e.Author)
                .Include(e => e.Category)
                .Include(e => e.Country)
                .Include(e => e.Language)
                .Include(e => e.Publisher)
                .SingleOrDefault(e => e.Id == book.Id);
        }
    }
}