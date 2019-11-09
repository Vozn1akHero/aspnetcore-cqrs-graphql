using GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL.Types
{
    public class PublisherType : ObjectGraphType<Publisher>
    {
        public PublisherType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}