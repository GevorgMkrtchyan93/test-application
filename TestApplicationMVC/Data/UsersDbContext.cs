using Microsoft.EntityFrameworkCore;
using TestApplicationMVC.Models;

namespace TestApplicationMVC.Data
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
