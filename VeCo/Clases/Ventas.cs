using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Ventas
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public int IdPrecio { get; set; }
        [ForeignKey("IdPrecio")]

        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Productos> Productos { get; set; }
        public ICollection<Precio> Precio { get; set; }

    }
}
