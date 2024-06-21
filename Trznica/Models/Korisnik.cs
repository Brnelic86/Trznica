using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class Korisnik
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ime i prezime su obavezni.")]
    public string ImePrezime { get; set; }

    [Required(ErrorMessage = "OIB je obavezan.")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "OIB mora sadržavati točno 11 znamenki.")]
    public string OIB { get; set; }

    [Required(ErrorMessage = "Korisničko ime je obavezno.")]
    public string KorisnickoIme { get; set; }

    [Required(ErrorMessage = "Lozinka je obavezna.")]
    public string Lozinka { get; set; }

    [Required(ErrorMessage = "Vrsta korisnika je obavezna.")]
    public string VrstaKorisnika { get; set; }
}
