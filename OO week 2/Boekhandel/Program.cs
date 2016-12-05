using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekhandel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boek> bladen = new List<Boek>();
            Boek boek = new Boek("Harry Potter", 10, 15.95);
            //  Boekhandel.VoegToe(boek, bladen); Hier gaat iets fout
            //  Boekhandel.PrintVoorraad(bladen);
            boek.WijzigVoorraad(45);
            DateTime datum = new DateTime(2016, 12, 05);
            Weekblad weekblad = new Weekblad("Donald Duck", 33, 4.95, datum);

            List<string> nummers = Nummers();
            Cd cd = new Cd("Back Through Time", "Alestorm", 15, 18.75, nummers);
            weekblad.WijzigVoorraad(-5);
            boek.Print();
            weekblad.Print();
            cd.Print();
            Console.ReadKey();
        }

        private static List<string> Nummers()
        {
            List<string> nummers = new List<string>();
            nummers.Add("Shipwrecked");
            nummers.Add("Keelhauled");
            nummers.Add("Back Through Time");
            return nummers;
        }
    }
}
