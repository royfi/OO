using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekhandel
{
    public class Weekblad : Boek
    {
        DateTime uitgifte;

        public Weekblad(string titel, int exemplaren, double prijs, DateTime uitgifte)
            : base(titel,exemplaren,prijs)
        {
            this.uitgifte = uitgifte;
        }

        public override void Print()
        {
            Console.WriteLine("{0} \n prijs : {1} \n Aantal Exemplaren : {2} \n Dag van uitgifte : {3}", titel, exemplaren, prijs, uitgifte);
        }
    }

}
