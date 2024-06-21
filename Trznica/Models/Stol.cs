using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trznica.Models
{
    public class Stol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RedniBroj { get; set; }
        public int StolVrstaStola {  get; set; }
        public int StolTrznica { get; set; }
        public string Status {  get; set; }
    }
}
