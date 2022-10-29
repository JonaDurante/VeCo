using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Productos
    {
        public int Id { get; set; }
        public long Stock { get; set; }
        public string Marca { get; set; }
        public string Imagen{ get; set; }
        public int IdDetalleProducto { get; set; }
        public ICollection<Favoritos> Favoritos { get; set; }
    }
}
    