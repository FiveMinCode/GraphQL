using GraphQL.API.Repositories;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.GraphQL
{
    public class BookQuery : ObjectGraphType<object>
    {
        public BookQuery(IBookRepository repository)
        {
            Name = "BookQuery";

            Field<BookInfoType>(
               "book",
               arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "bookId" }),
               resolve: context => repository.GetBookById(context.GetArgument<int>("bookId"))
            );

            Field<ListGraphType<BookInfoType>>(
             "books",
             resolve: context => repository.GetBooksInfo()
          );
        }
    }
}
