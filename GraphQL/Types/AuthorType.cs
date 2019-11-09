using GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.Surname);
        }
    }
}