using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_3_kolokvij
{
    class Limeta: Sastojak
    {
        public Limeta(double kolicina) : base(kolicina)
        {
        
        }

        public override void Prikazi()
        {
            Console.WriteLine("{0} limete", base.VratiKolicinu());
        }
        public override double VratiDecilitre()
        { 
            return (base.VratiKolicinu()*0.4);
        }
    }
}
