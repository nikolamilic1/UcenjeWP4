using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.Edunova;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaSmjer
    {

        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer() 
        {
            Smjerovi = new List<Smjer>();

            
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa smjerovima");
            Console.WriteLine("1 Pregled svih smjerova");
            Console.WriteLine("2 Promjena podataka postojećeg smjera");
            Console.WriteLine("3 Unos novog smjera");
            Console.WriteLine("4 Brisanje smjera");
            Console.WriteLine("5 Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1,5))
            {
                case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;
                
                
                
                case 5:
                   // Console.WriteLine("Gotov rad sa smjerovima");
                    Console.Clear();
                    break;
            }
        }


 



        private void UnosNovogSmjera()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Unesite tražene podatke o smjeru:");
            Smjerovi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera",50, true),
                Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera",0,10000),
                IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kada se izvodi smjer",true)
                Verificiran = Pomocno.UcitajBool("Da li je smjer verificaran? (DA/NE","da")
            });
        }
    }
}
