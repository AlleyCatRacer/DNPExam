using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuthorAPI.Persistence.Authors
{
    public class AuthorData : IAuthorData
    {
        private readonly AuthorDbContext _dbContext;
        public async Task<IList<Author>> GetAuthors()
        {
            return await _dbContext.Authors.Include(a => a.Books).ToListAsync();
        }

        public async Task<Author> Add(Author author)
        {
            EntityEntry<Author> added = await _dbContext.Authors.AddAsync(author);
            await _dbContext.SaveChangesAsync();
            return added.Entity;
        }
    }
}