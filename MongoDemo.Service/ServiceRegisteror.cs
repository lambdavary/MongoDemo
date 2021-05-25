using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDemo.Service
{
    public static class ServiceRegisteror
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
            => services.AddScoped<IBookService, BookService>();
    }
}
