using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using VeCo.Model;

namespace VeCo.Data
{
    public class VecoContext : DbContext
    {
        public VecoContext(DbContextOptions<VecoContext> options) : base(options)
        {

        }

        // Creo entidades con DbSet partiendo de las Model .cs 
        public DbSet<DetalleProducto> DetalleProducto { get; set; }
        public DbSet<Dolares> Dolares { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Roles> Roles{ get; set; }
        public DbSet<Usuarios> Usuarios{ get; set; }
        
    }
}
