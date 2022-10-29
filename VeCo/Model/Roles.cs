using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Roles
    {

        public int Id { get; set; }
        public string NivelPermiso { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
