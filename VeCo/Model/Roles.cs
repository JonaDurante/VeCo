using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Model
{
    public class Roles
    {

        public int Id { get; set; }
        public string NivelPermiso { get; set; }
    }
}
