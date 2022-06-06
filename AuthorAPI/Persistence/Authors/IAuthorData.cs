
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Models;

namespace AuthorAPI.Persistence.Authors
{
    public interface IAuthorData
    {
        Task<IList<Author>> GetAuthors();
        Task<Author> Add(Author author);
    }
}