using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiceRoll.Models
{
    
    public class Dice
    {
        Random number = new Random();
        Random number2 = new Random();
        public int DiceId { get; set; }
      

        public void Roll()
        {
            number.Next(0, 6);
            number2.Next(0, 6);
            Console.WriteLine("{0),{1}", number, number2);

        }
    }
   

}