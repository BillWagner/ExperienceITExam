using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DicePages.Models
{
    public class Dice
    {
        public int DIE1 { get; set; }
        public int DIE2 { get; set; }
        Random rng = new Random();
        public void RollDice()
        {
            DIE1 = rng.Next(1, 6);
            DIE2 = rng.Next(1, 6);
        }
    }
}