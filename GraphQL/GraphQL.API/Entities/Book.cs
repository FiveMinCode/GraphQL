using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQL.API.Entities
{
    public partial class Book
    {
        public Book()
        {
            BookPublishers = new HashSet<BookPublisher>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<BookPublisher> BookPublishers { get; set; }
    }
}
