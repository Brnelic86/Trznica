using System.ComponentModel.DataAnnotations.Schema;

namespace Trznica.Models
{
    public class Ugovor
    {
        public int Id { get; set; }
        public int RedniBroj {  get; set; }
        public int UgovorKorsinik {  get; set; }
        public string TipUgovora { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Iznos { get; set; }
        public string Status { get; set; }
        public DateTime? DatumOdobrenja { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public int UgovorStol {  get; set; }
    }
}
