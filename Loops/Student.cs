using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       /****      QUEStiON #2   ****/
       public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

       //or
       public void printFullName() {
           Console.WriteLine(this.FirstName +  " " + this.LastName);
       }


    }
}
