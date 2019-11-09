using GraphQL.Types;
using GraphQL;

namespace librarygraphql.GraphQL
{
    public class BookSchema : Schema
    {
        public BookSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<BookQuery>();
            Mutation = resolver.Resolve<BookMutation>();
        }
    }
}