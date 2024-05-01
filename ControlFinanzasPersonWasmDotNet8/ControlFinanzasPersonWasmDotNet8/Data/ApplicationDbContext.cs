using ControlFinanzasPersonWasmDotNet8.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ControlFinanzasPersonWasmDotNet8.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
    }
}
