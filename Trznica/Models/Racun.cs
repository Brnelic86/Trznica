using System.ComponentModel.DataAnnotations.Schema;

namespace Trznica.Models
{
    public class Racun
    {
        public int Id { get; set; }
        public int RacunKorisnik { get; set; }
        public string TipRacuna {  get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Iznos {  get; set; }
        public string Status { get; set; }
        public DateTime DatumRacuna { get; set; }
    }
}
