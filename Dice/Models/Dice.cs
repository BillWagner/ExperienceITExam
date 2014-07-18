using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dice.Models
{
    public class Dice
    {
        [Key]
        public int die1 { get; set; }
        public int die2 { get; set; }

        public class DiceContext : DbContext
        {
        }
    }
}