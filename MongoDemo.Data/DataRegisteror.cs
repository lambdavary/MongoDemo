using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDemo.Data
{
    public static class DataRegisteror
    {
        public static IServiceCollection RegisterData(this IServiceCollection services)
            => services.AddScoped<IBookRepository, BookRepository>();
    }
}
