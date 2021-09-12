using GraphQL.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.Repositories
{
    public interface IBookRepository
    {
        Task<Book[]> GetBooksInfo();
        Task<Book> GetBookById(int id);
        Task<List<Publisher>> GetPublisherInfoByBookId(int id);
    }
}
