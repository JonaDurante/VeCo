using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeCo.Model
{
    public class Dolares
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal DolarOficial { get; set; }
        public decimal DolarMinorista { get; set; }
        public decimal DolarMayorista { get; set; }
        public decimal DolarBlue { get; set; }
        public decimal DolarBCRA { get; set; }
        public decimal DolarBancoNacion { get; set; }
    }
}
