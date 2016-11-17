using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeGame
    {
        public int[] dobbelstenen;
        public Random rnd;

        public YahtzeeGame()
        {
            int[] dobbelstenen = new int[5];

            this.dobbelstenen = dobbelstenen;
            this.rnd = new Random();
        }

        public void Gooi()
        {           

            for(int i = 0; i < 5; i++)
            {
               
                dobbelstenen[i] = rnd.Next(1,6);
                Console.WriteLine(dobbelstenen[i]);
            }
            

        }
        public bool Yahtzee()
        {
           int checkYahtzee = dobbelstenen[1];
           
            for (int i = 1; i < 5; i++)
            {
                if(dobbelstenen[i] == checkYahtzee)
                {
                    return true;
                }
            
            }

           
        }

    }
}
