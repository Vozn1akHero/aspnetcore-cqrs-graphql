using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using librarygraphql.Commands;
using librarygraphql.Commands.Handlers;
using librarygraphql.GraphQL.InputTypes;
using librarygraphql.GraphQL.Types;
using librarygraphql.Models;

namespace librarygraphql.GraphQL
{
    public class BookMutation : ObjectGraphType
    {
        public BookMutation(BookCommandHandler commandHandler)
        {
            Field<BookType>(
                "createBook",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<BookInputType>> { Name = "book", Description = "book" }
                ),
                resolve: context =>
                {
                    //var human = context.GetArgument<Human>("human");
                    var book = context.GetArgument<Book>("book");
                    var command = new CreateBookCommand
                    {
                        AuthorId = book.AuthorId,
                        CategoryId = book.CategoryId,
                        CountryId = book.CountryId,
                        LanguageId = book.LanguageId,
                        PublisherId = book.PublisherId, 
                        Description = book.Description, 
                        Title = book.Title
                    };
                    /*var command = new CreateBookCommand
                    {
                        AuthorId = context.GetArgument<int>("authorId"),
                        CategoryId = context.GetArgument<int>("categoryId"),
                        CountryId = context.GetArgument<int>("countryId"),
                        LanguageId = context.GetArgument<int>("languageId"),
                        PublisherId = context.GetArgument<int>("publisherId"), 
                        Description = context.GetArgument<string>("description"), 
                        Title = context.GetArgument<string>("title")
                    };*/

                    return commandHandler.Handle(command);
                });
        }
    }
}