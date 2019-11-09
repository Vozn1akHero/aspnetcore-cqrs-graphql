using System.Linq;
using GraphQL.Types;
using librarygraphql.GraphQL.Types;
using librarygraphql.Models;
using System.Collections.Generic;
using System.Linq;
using librarygraphql.Queries;
using librarygraphql.Queries.Handler;
using Microsoft.EntityFrameworkCore;

namespace librarygraphql.GraphQL
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery(BookQueryHandler queryHandler)
        {
            Field<BookType>(
                "book",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the book." }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    var query = new GetBookByIdQuery { Id = id };
                    var book = queryHandler.Handle(query);
                    return book;
                });

            Field<ListGraphType<BookType>>(
                "books",
                resolve: context =>
                {
                    var query = new GetBooksQuery();
                    var books = queryHandler.Handle(query);
                    return books;
                });
        }
    }
}