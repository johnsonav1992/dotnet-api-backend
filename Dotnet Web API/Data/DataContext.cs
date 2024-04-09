using Dotnet_Web_API.UserModels;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Web_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; } 
    }
}