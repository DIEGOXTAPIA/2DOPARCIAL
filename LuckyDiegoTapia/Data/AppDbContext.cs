using LuckyDiegoTapia.Models;
using Microsoft.EntityFrameworkCore;

namespace LuckyDiegoTapia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Suerte> Suerte { get; set; }
    }
}
