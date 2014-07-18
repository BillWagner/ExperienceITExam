using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
   public virtual class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print(string s)
        {
            Console.WriteLine(s);
        }
   }

    
}

