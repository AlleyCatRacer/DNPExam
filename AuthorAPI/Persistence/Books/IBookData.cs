using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Models;

namespace AuthorAPI.Persistence.Books
{
    public interface IBookData
    {
        Task<IList<Book>> GetBooks();
        Task<Book> Add(Book book);

        Task Remove(int isbn); 
    }
}