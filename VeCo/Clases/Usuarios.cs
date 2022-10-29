using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Usuarios
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Mail { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int IdRoles {get; set; }
        [ForeignKey("IdRoles")]
        public Roles Roles {get; set; }
        public Compras Compras { get; set; }
        public Ventas Ventas{ get; set; }
        public Favoritos Favoritos { get; set; }
    } 
}
