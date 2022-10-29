using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Clases
{
    public class Roles
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRoles { get; set; }
        public string NivelPermiso { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
