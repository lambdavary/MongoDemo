using MongoDB.Driver;
using MongoDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDemo.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> bookRepository;

        public BookRepository()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("BookstoreDb");

            bookRepository = database.GetCollection<Book>("Books");
        }

        public List<Book> GetBooks()
            => bookRepository.AsQueryable().ToList();
    }
}
