using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using VeCo.Clases;

namespace VeCo.DataBase
{
    public class VecoContext : DbContext
    {
        private const string connectionString = @"Data Source=NKO\SQLEXPRESS; Initial Catalog=VeCo; Integrated Security=True";

        public VecoContext(DbContextOptions<VecoContext> options) : base(options)
        {

        }

        // Creo entidades con DbSet partiendo de las clases .cs 
        public DbSet<DetalleProducto> DetalleProducto { get; set; }
        public DbSet<Dolares> Dolares { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Roles> Roles{ get; set; }
        public DbSet<Usuarios> Usuarios{ get; set; }
        
    }
}
