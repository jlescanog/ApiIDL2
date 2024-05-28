using Microsoft.EntityFrameworkCore;
using ApiIDL2.Models;

namespace ApiIDL2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
