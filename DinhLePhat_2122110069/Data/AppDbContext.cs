using DinhLePhat_2122110069.Models;
using Microsoft.EntityFrameworkCore;

namespace DinhLePhat_2122110069.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}