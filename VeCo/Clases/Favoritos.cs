using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Favoritos
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFavoritos { get; set; }
        public DateTime Fecha { get; set; }
        public int EnFavoritos { get; set; }
        public int MeGusta { get; set; }
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Productos> Productos { get; set; }

    }
}

