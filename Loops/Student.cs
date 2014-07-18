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
    
     public static void printit(List<Student> stud)
     {
         foreach(var student in stud)
         Console.WriteLine(student.FirstName + " " + student.LastName);
     }
   
   }
}
