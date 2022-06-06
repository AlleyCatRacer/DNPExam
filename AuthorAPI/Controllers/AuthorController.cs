using AuthorAPI.Persistence.Authors;
using Microsoft.AspNetCore.Mvc;

namespace AuthorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController
    {
        private readonly IAuthorData authorData;

        //public AuthorController(IAuthorData author);
    }
}