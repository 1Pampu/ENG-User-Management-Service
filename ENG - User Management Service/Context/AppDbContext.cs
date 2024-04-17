using ENG___User_Management_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace ENG___User_Management_Service.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}