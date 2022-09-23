using Microsoft.EntityFrameworkCore;

namespace basicapi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<EndPointOne> EndPoints { get; set; }
    }
}
