using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekhandel
{
   public class Boek
    {
        public string titel;
        public int exemplaren;
        public double prijs;

        public Boek(string titel, int exemplaren, double prijs)
        {
            this.titel = titel;
            this.exemplaren = exemplaren;
            this.prijs= prijs;
        }


        public virtual void Print()
        {
            Console.WriteLine("{0} \n prijs : {1} \n Aantal Exemplaren : {2}", titel, exemplaren, prijs);
        }

        public int WijzigVoorraad(int wijziging)
        {
            exemplaren = exemplaren + wijziging;
            return exemplaren;

        }


    }
}
