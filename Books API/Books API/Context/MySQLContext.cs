using Microsoft.EntityFrameworkCore;
using Books_API.Models;

namespace Books_API.Context {
    public class MySQLContext : DbContext{

        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }

    }
}
