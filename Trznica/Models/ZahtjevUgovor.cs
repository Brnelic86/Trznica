using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trznica.Models
{
    public class ZahtjevUgovor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        public int RedniBroj { get; set; }
        public int ZahtjevUgovorKorisnik {  get; set; }
        public string TipUgovora { get; set; }
        public string Status { get; set; }
        public DateTime DatumZahtjeva { get; set; }
        public int ZahtjevUgovorStol {  get; set; }

    }
}
