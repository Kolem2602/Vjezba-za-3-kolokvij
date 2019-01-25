using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_3_kolokvij
{
    class Rum:Sastojak
    {
        private string naziv;
        public Rum (double kolicina, string naziv) : base (kolicina)
        {
            this.naziv = naziv;
           
        }

        public override void Prikazi()
        {
            Console.WriteLine("{0}dcl ruma {1}", base.VratiKolicinu(), naziv);
        }

        public override double VratiDecilitre()
        {
            return base.VratiKolicinu();
        }
    }


}
