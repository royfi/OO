using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programeurs
{
    public class Team
    {
        public List<Programmeur> AddTeam()
        {
            List<Programmeur> team = new List<Programmeur>();

            for (int i = 0; i < 4; i++)
            {             

                Console.WriteLine("Voer een Naam in!");
                string naam = Console.ReadLine();
                Console.WriteLine("Voer {0} zijn Programeer specialiteit in! ", naam);

                string special = Console.ReadLine();
                Specialiteit specialiteit = (Specialiteit)Enum.Parse(typeof(Specialiteit), special);

                team.Add(new Programmeur(naam, specialiteit));

            }
            return team;
           
        }
        public void PrintTeam(List<Programmeur> team)
        {


        }


    }
}
