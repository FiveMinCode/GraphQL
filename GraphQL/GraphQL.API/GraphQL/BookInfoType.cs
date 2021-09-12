using GraphQL.API.Entities;
using GraphQL.API.Repositories;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.GraphQL
{
    public class BookInfoType : ObjectGraphType<Book>
    {
        public BookInfoType(IBookRepository repository)
        {
            Field(x => x.BookId).Description("Book id.");
            Field(x => x.Name).Description("Book name.");
            Field(x => x.Author).Description("Author name.");
            Field(x => x.ReleaseDate).Description("Release date.");

            Field<ListGraphType<PublisherType>>(
              "publishers",
              arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "bookId" }),
              resolve: context => repository.GetPublisherInfoByBookId(context.Source.BookId)
           );
        }
    }
}
