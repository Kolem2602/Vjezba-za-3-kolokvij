using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_3_kolokvij
{
    class Sastojak
    {
        private double dcl { get; set; }
        private double kolicina { get; set;}
        

        public Sastojak ()
        {
            kolicina = 1;
        }
        public Sastojak (double kolicina)
        {
            this.kolicina = kolicina;
        }
        public virtual void Prikazi()
        {

        }

        public double VratiKolicinu()
        {

            return kolicina;
        }

        public virtual double VratiDecilitre()
        {
            return dcl;
        }
    }
}
