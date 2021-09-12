using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.GraphQL
{
    public class BookSchema : Schema
    {
        public BookSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<BookQuery>();
        }

    }
}