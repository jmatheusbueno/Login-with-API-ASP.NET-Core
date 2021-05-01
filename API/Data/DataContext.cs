using Microsoft.EntityFrameworkCore;
using Models.User;

namespace Data.DataContext
{
    public class DataContext : DbContext
    {
        public DbSet<User> User { get; set; } 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
