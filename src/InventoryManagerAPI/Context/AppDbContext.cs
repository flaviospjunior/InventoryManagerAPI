using InventoryManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagerAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Material> Materiais { get; set; }

    }
}
