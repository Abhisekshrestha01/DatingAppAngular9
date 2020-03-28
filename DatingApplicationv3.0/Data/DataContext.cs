using Microsoft.EntityFrameworkCore;

namespace DatingApplicationv3._0.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Models.Value> Values { get; set; }
    }
}