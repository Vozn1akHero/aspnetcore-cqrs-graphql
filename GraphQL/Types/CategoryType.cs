using GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL.Types
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
        }
    }
}