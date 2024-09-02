using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer:Entitet
    {
        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        [Column("verificiran")]   //nije obavezno napraviti  --naznaka da se Vaucer odnosi na verificarn
        public bool? Vaucer { get; set; }
    }
}
