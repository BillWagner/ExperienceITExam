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

        private void PrintStudents(List<Student> allStud)
        {
            for (int i = 0; i < allStud.Count; i++)
            {
                Console.WriteLine(allStud[i].FirstName + " " + allStud[i].LastName);
            }
            Console.ReadLine();
        }
    }
}
