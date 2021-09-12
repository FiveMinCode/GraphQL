using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQL.API.Entities
{
    public partial class BookPublisher
    {
        public int BookPublisherId { get; set; }
        public int BookId { get; set; }
        public int? PublisherId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
