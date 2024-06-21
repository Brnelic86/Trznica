using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trznica.Models
{
    public class Racun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RacunKorisnik { get; set; }
        public string TipRacuna {  get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Iznos {  get; set; }
        public string Status { get; set; }
        public DateTime DatumRacuna { get; set; }
        public int RacunStol { get; set; }
    }
}
