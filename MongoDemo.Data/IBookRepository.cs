using MongoDemo.Model;
using System.Collections.Generic;

namespace MongoDemo.Data
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
    }
}