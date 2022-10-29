using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Productos
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public long Stock { get; set; }
        public string Marca { get; set; }
        public string Imagen{ get; set; }
        public int IdDetalleProducto { get; set; }
        [ForeignKey("IdDetalleProducto")]
        public DetalleProducto DetalleProducto { get; set; }
        public Compras Compras { get; set; }
        public Ventas Ventas { get; set; }
        public Favoritos Favoritos { get; set; }
    }
}
    