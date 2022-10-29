using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using VeCo.Clases;

namespace VeCo.DataBase
{
    public class DBHandler : DbContext
    {
        private const string connectionString = @"Data Source=NKO\SQLEXPRESS; Initial Catalog=VeCo; Integrated Security=True";


        // Encargado de crear la instancia hacia el servidor sql server con el que nos queremos conectar
        // Se debe sobreescribir el método Void OnConfiguring el cual recibe como parametro de entrada un DbContextOptionsBuilder optionsBuilder
        // Al ser protected, me aseguro que las clases que lo hereden, tengan acceso a el.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Defino la conexion asignandole el connection string
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Le digo a EntityFrameworkCore que poseo una tabla con dos claves foraneas usando HasKey y diciendole el nombre de estas FK
        // Siempre que tenga una tabla con más de una FK debo utilizar este método.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Compras>().HasKey(xi => new { xi.IdPrecio, xi.IdProducto, xi.IdUsuario });
        //    modelBuilder.Entity<Ventas>().HasKey(xi => new { xi.IdPrecio, xi.IdProducto, xi.IdUsuario });
        //    //modelBuilder.Entity<Favoritos>().HasKey(xi => new { xi.IdProducto, xi.IdUsuario });

        //    //modelBuilder.Entity<DetalleProducto>().HasKey(xi => new { xi.idProducto });
        //    //modelBuilder.Entity<Productos>().HasKey(xi => new { xi.IdDetalleProducto });
        //    //modelBuilder.Entity<Dolares>().HasNoKey();
        //    //modelBuilder.Entity<Precio>().HasKey(xi => new { xi.Compras, xi.Ventas });
        //}

        // Creo entidades con DbSet partiendo de las clases .cs 
        public DbSet<Compras> Compras { get; set; }
        public DbSet<DetalleProducto> DetalleProducto { get; set; }
        public DbSet<Dolares> Dolares { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Roles> Roles{ get; set; }
        public DbSet<Usuarios> Usuarios{ get; set; }
        public DbSet<Ventas> Ventas{ get; set; }
        
    }
}
