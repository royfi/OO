using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersoonStruct p1 = new PersoonStruct("Simon", 40);
            PersoonClass p2 = new PersoonClass("Chris", 50);

            Console.WriteLine("struct persoon: " + p1.naam + ", " + p1.leeftijd);
            Console.WriteLine("class persoon: " + p2.naam + ", " + p2.leeftijd);
            Console.WriteLine();

            WijzigLeeftijd(p1, p2);
   //         WijzigLeeftijd(p2);

            Console.WriteLine("struct persoon: " + p1.naam + ", " + p1.leeftijd);
            Console.WriteLine("class persoon: " + p2.naam + ", " + p2.leeftijd);
            Console.WriteLine();

            Console.ReadKey();
        }


        static void WijzigLeeftijd(PersoonStruct p1 = null, PersoonClass p2 = null) // waarschijnlijk kan dit mooier en netter 
        {
            if (p1 != null)
            {
               
                p1.leeftijd++;
            }
            if (p2 != null)
            {
                p2.leeftijd++;
            }

        }
        
    }

}
