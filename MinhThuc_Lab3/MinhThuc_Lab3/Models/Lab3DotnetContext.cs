using Microsoft.EntityFrameworkCore;

namespace MinhThuc_Lab3.Models
{

    public class Lab3DotnetContext : DbContext
    {
        public Lab3DotnetContext(DbContextOptions<Lab3DotnetContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }

    }

}
