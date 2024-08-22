using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaApp.Models
{
    public class Smjer:Entitet
    {

        public string? Naziv { get; set; }
        public  int? Trajanje { get; set; }

        public decimal? Cijena { get; set; }

        public  DateTime? IzvodiSeOd { get; set; }

        [Column("verificiran")]  // ne mora biti u završnom radu
        public bool? Vaucer { get; set; }

    }
}
