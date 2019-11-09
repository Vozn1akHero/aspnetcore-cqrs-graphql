using GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL.Types
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Description);
            Field<AuthorType>(nameof(Author));
            Field<CategoryType>(nameof(Category));
            Field<CountryType>(nameof(Country));
            Field<LanguageType>(nameof(Language));
            Field<PublisherType>(nameof(Publisher));
        }
    }
}