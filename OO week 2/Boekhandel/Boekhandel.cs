using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekhandel
{
    public class Boekhandel
    {
        public List<Boek> bladen()
        {
            List<Boek> bladen = new List<Boek>();
            return bladen;
        }

        public List<Boek> VoegToe(Boek boek, List<Boek>bladen)
        {
           
            bladen.Add(boek);
            return bladen;
        }
       

        public void PrintVoorraad(List<Boek> bladen)
        {
            foreach(Boek boek in bladen)
            {

                boek.Print();
            }
        }



    }
}
