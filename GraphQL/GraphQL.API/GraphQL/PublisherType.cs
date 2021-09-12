using GraphQL.API.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.GraphQL
{
    public class PublisherType : ObjectGraphType<Publisher>
    {
        public PublisherType()
        {
            Field(x => x.PublisherId).Description("Publisher id.");
            Field(x => x.Name).Description("Publisher name.");
            Field(x => x.Email).Description("Publisher Email address.");
            Field(x => x.Phone).Description("Publisher phone number.");
        }
    }
}
