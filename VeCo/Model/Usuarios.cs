using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Mail { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Roles Roles {get; set; }
        public ICollection<Favoritos> Favoritos { get; set; }
    } 
}
