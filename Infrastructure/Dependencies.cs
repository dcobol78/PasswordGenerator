using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            // Конфигурация к бд
            services.AddDbContext<PasswordContext>(c =>
                c.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-PasswordsDb;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }
    }
}
