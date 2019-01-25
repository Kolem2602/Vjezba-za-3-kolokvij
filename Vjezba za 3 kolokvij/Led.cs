using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_3_kolokvij
{
    class Led : Sastojak
    {
        private string naziv { get; set; }
        public Led(string naziv) : base()
        {
            this.naziv = naziv;
        }

        public override void Prikazi()
        {
            Console.WriteLine("Led {0}",naziv);

        }
        public override double VratiDecilitre()
        {
            return 1;
        }
    }
}
