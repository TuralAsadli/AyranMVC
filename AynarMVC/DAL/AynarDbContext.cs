using AynarMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AynarMVC.DAL
{
    public class AynarDbContext : DbContext
    {
        public AynarDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }

        public DbSet<SosialLinks> SosialLinks { get; set; }
    }
}
