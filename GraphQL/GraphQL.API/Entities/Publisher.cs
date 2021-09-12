using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQL.API.Entities
{
    public partial class Publisher
    {
        public Publisher()
        {
            BookPublishers = new HashSet<BookPublisher>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<BookPublisher> BookPublishers { get; set; }
    }
}
