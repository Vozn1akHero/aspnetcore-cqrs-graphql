using GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL.Types
{
    public class LanguageType : ObjectGraphType<Language>
    {
        public LanguageType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}