using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programeurs
{
    public class Team
    {
        List<Programmeur> programmeurs = new List<Programmeur>();

        public void AddProgrammeurs(Programmeur p)
        {
            programmeurs.Add(p);


        }

        public void PrintAlleTeamleden(List<Programmeur> team)
        {
            foreach(Programmeur p in team)
            {
                p.PrintProgrammeur();
            }

        }

    }
}
