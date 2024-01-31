using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RepostriyUOW.core.Models;
using RepostriyUOW.core.Repostries;

namespace RepostriyUOW.Controller
{
    [ApiController]
    [Route("Controller")]
    public class BookController : ControllerBase
    {
        protected readonly IBaseRepostry<Book> _bookRepostry;

        public BookController(IBaseRepostry<Book> bookRepostry)
        {
            _bookRepostry = bookRepostry;
        }

        [HttpGet("get_book_by_id")]
        public Book GetByID()
        {
            return _bookRepostry.GetById(2);
        }
    }
}
