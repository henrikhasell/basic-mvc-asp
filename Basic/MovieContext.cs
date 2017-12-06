using Microsoft.EntityFrameworkCore;

namespace Basic
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Models.Movie> Movies { get; set; }
    }
}