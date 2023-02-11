using Microsoft.EntityFrameworkCore;
using CPW219_AspnetMVC_CRUD_Debugging.Models;

namespace CPW219_AspnetMVC_CRUD_Debugging.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}
