using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programeurs
{
   public class Programmeur
    {
        string naam;
        Specialiteit specialiteit;

        public Programmeur(string naam, Specialiteit specialiteit)
        {
            this.naam = naam;
            this.specialiteit = specialiteit;
        }
        public void PrintProgrammeur()
        {
            Console.WriteLine("Naam Programeur: {0} \nSpecialiteit: {1} \n", naam, specialiteit);
        }

    }
}
