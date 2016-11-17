using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programeurs
{
    public class Team
    {
        List<Programmeur> team = new List<Programmeur>();

        public void AddProgrammeurs(Programmeur p)
        {
            team.Add(p);


        }

        public void PrintAlleTeamleden()
        {
            foreach(Programmeur p in team)
            {
                p.PrintProgrammeur();
            }

        }

    }
}
