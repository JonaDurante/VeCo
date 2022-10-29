using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class DetalleProducto
    {
        [Key]
        ////[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalleProducto { get; set; }
        public string Descripción { get; set; }
        public int idProducto { get; set; }
        [ForeignKey("IdProducto")]
        public ICollection<Productos> Producto { get; set; }
    }
}
