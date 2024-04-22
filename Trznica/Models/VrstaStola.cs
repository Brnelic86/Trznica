using System.ComponentModel.DataAnnotations.Schema;

namespace Trznica.Models
{
    public class VrstaStola
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal CijenaDan {  get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CijenaMjesec { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CijenaGodina { get; set; }
        public string Opis {  get; set; }
    }
}
