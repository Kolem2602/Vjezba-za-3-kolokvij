using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_3_kolokvij
{
    class CocaCola : Sastojak
    {
        private string naziv { get; set; }
        public CocaCola(double kolicina, string naziv) : base(kolicina)
        {
            
            this.naziv = naziv;
        }

        public override void Prikazi()
        {
            Console.WriteLine("{0} Coca-Cola {1}", base.VratiKolicinu(), naziv);
        }
        public override double VratiDecilitre()
        {
            return (base.VratiKolicinu() * 2.5);
        }
    }
}
