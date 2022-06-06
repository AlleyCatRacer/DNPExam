using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuthorAPI.Persistence.Books
{
    public class BookData : IBookData
    {
        private readonly AuthorDbContext _dbContext;

        public BookData() => _dbContext = new AuthorDbContext();
        
        public async Task<IList<Book>> GetBooks()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> Add(Book book)
        {
            // Author author = await _dbContext.Authors.Include(a => a.Books).FirstAsync(a => a.Id == authorId);
            // author.Books.Add(book);
            EntityEntry<Book> added = await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
            return added.Entity;
        }

        public async Task Remove(int isbn)
        {
            Book toRemove = await _dbContext.Books.FirstAsync(b => b.ISBN.Equals(isbn));
            if (toRemove != null)
            {
                _dbContext.Books.Remove(toRemove);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}