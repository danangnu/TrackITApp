using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> ftstaff { get; set; }
        public DbSet<Keywords> ftkeywords { get; set; }
    }
}