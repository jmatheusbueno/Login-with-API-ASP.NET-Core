using Microsoft.EntityFramerkCore;
using Models.User;

namespace Data.DataContent
{
    public class DataContent : DbContext
    {
        public DbSet<User> User { get; set; } 

        public DataContent(DbContextOptions<DataContent> options) : base(options)
        {
            
        }
    }
}
