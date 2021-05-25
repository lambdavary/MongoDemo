using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDemo.Model;
using MongoDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IBookService bookService;

        public HomeController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public List<Book> GetBooks()
            => bookService.GetAllBooks();
    }
}
