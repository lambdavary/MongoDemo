using MongoDemo.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDemo.Service
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
    }
}
