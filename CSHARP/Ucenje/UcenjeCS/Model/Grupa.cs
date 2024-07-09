using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Model
{
    internal class Grupa:Entitet
    {
        public string?  Naziv { get; set; }
        public string? Name { get; set; }

        public string? Predavac { get; set; }

        public int? MaksimalnoPolaznika { get; set; }

        public List<Polaznik>? Polaznici { get; set;}


    }
}
