using MongoDemo.Data;
using MongoDemo.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDemo.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public List<Book> GetAllBooks()
            => bookRepository.GetBooks();
    }
}
