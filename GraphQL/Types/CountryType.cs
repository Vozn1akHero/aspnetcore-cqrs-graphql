using GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL.Types
{
    public class CountryType : ObjectGraphType<Country>
    {
        public CountryType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}