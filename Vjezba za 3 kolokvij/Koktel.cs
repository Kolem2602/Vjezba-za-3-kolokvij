using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_3_kolokvij
{
    class Koktel : Sastojak
    {
        private string naziv { get; set; }
        private double x = 0;
        public Koktel (string naziv)
        {
            this.naziv = naziv;
        }
        public List<Sastojak> sastojci = new List<Sastojak>();
        public void Dodaj(Sastojak s1)
        {

            sastojci.Add(s1);
        }

        public void Posluzi()
        {
            Console.WriteLine("Posluzujem koktel {0}", naziv);
            Console.WriteLine("Sastojci ({0}):", sastojci.Count);
            foreach (Sastojak s1 in sastojci)
            {
                s1.Prikazi();
                x += s1.VratiDecilitre();
            }
            Console.WriteLine("Potrebna casa minimalno dcl: {0}", x);
        }

       
    }
}
