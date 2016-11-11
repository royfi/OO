using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programeurs
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            Programmeur p = new Programmeur("Jan", Specialiteit.PHP);

            p.PrintProgrammeur();
            Team team = new Team();
            team.AddProgrammeurs(p);

            team.AddProgrammeurs(p);
            team.AddProgrammeurs(new Programmeur("Mark", Specialiteit.Csharp));
            team.AddProgrammeurs(new Programmeur("Yuri", Specialiteit.HTML));
            team.AddProgrammeurs(new Programmeur("Quintus", Specialiteit.Java));

            team.PrintAlleTeamleden();
        }
    }
}
