using GraphQL.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly GraphQLContext _context;

        public BookRepository(GraphQLContext context)
        {
            this._context = context;
        }

        public async Task<List<Publisher>> GetPublisherInfoByBookId(int id)
        {
            return await (from ep in this._context.BookPublishers
                          join p in this._context.Publishers on ep.BookId equals p.PublisherId
                          where ep.BookId == id
                          select p).ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await Task.FromResult(_context.Books.FirstOrDefault(i => i.BookId == id));
        }

        public async Task<Book[]> GetBooksInfo()
        {
            return await Task.FromResult(_context.Books.ToArray());
        }
    }
}
