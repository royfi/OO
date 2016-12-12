using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaartspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Kaartspel spel = new Kaartspel(2);
            spel.Print();
            Console.ReadKey();
        }
    }
}
