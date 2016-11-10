using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programeurs
{
   public class Programmeur
    {
        string Naam;
        Specialiteit specialiteit;

        public Programmeur(string Naam, Specialiteit specialiteit)
        {
            this.Naam = Naam;
            this.specialiteit = specialiteit;
        }
        public void PrintProgrammeur(string Naam, Specialiteit specialiteit)
        {
            Console.WriteLine("Naam Programeur: {0} /n Specialiteit: {1}", Naam, specialiteit);
        }

    }
}
