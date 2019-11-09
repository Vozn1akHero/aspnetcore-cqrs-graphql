using GraphQL.Types;

namespace librarygraphql.GraphQL.InputTypes
{
    public class BookInputType : InputObjectGraphType
    {
        public BookInputType()
        {
            Name = "BookInput";
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<NonNullGraphType<StringGraphType>>("description");
            Field<NonNullGraphType<IntGraphType>>("authorId");
            Field<NonNullGraphType<IntGraphType>>("categoryId");
            Field<NonNullGraphType<IntGraphType>>("countryId");
            Field<NonNullGraphType<IntGraphType>>("languageId");
            Field<NonNullGraphType<IntGraphType>>("publisherId");
        }
    }
}