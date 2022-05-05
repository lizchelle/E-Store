using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Configuration;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products {get; set;}
    }
}

   