using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random s = new Random();
            int sInt = s.Next(0, 6);

            Random f = new Random();
            int fInt = f.Next(0, 6);
            
            if (sInt == fInt)
            {
                fInt = 2;
                
            }
            






            string[] die1 = { "1", "2", "3", "4" ,"5", "6"};
            string j = die1[sInt];

            string[] die2 ={"1 ", "2 ", "3 ", "4 ", "5 ",
                "6 "};
            string k = die2[fInt];

            Console.WriteLine(k + j);

            Console.ReadLine();

        }

    }
}
