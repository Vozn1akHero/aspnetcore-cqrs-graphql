using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarygraphql.Models;
using Microsoft.EntityFrameworkCore;

namespace librarygraphql.Queries.Handler
{
    public class BookQueryHandler
    {
        private readonly LibraryContext _libraryContext;

        public BookQueryHandler(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public async Task<Book> Handle(GetBookByIdQuery query)
        {
            return await _libraryContext.Set<Book>()
                .Include(e => e.Author)
                .Include(e => e.Category)
                .Include(e => e.Country)
                .Include(e => e.Language)
                .Include(e => e.Publisher)
                .SingleOrDefaultAsync(e => e.Id == query.Id);
        }

        public async Task<IEnumerable<Book>> Handle(GetBooksQuery query)
        {
            var books = await _libraryContext
                .Set<Book>()
                .Include(e => e.Author)
                .Include(e => e.Category)
                .Include(e => e.Country)
                .Include(e => e.Language)
                .Include(e => e.Publisher)
                .ToListAsync();
            return books;
        }
    }
}