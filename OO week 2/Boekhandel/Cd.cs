using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekhandel
{
   public class Cd : Boek
    {
        string zanger;
        public List<string>nummers;
            
        public Cd(string titel, string zanger, int exemplaren, double prijs, List<string> nummers)
            :base (titel,exemplaren,prijs)
        {
            this.nummers = nummers;
        }
        public override void Print()
        {
            Console.WriteLine(" {0} \n {1} prijs : {2} \n Aantal Exemplaren : {3} \n nummers:  {4} \n", titel, zanger, prijs, exemplaren, nummers);
        }

    }
}
