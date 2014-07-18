using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class myExtensionMethond
    {
        public static bool GreaterThan(this Person human, Person num2)
        {
            int length1, lenght2, length3, length4;
            length1 = human.FirstName.Count();
            lenght2 = human.LastName.Count();
            length3 = num2.FirstName.Count();
            length4 = num2.LastName.Count();
            if ((length1 + lenght2) > (length3 + length4))
                return true;
            else
                return false;
        }
        public static bool LessThan(this Person human, Person x)
        {
            int length1, lenght2, length3, length4;
            length1 = human.FirstName.Count();
            lenght2 = human.LastName.Count();
            length3 = x.FirstName.Count();
            length4 = x.LastName.Count();
            if ((length1 + lenght2) < (length3 + length4))
                return true;
            else
                return false;
        }
        public static bool GreaterThanOrEqual(this Person human, Person x)
        {
            int length1, lenght2, length3, length4;
            length1 = human.FirstName.Count();
            lenght2 = human.LastName.Count();
            length3 = x.FirstName.Count();
            length4 = x.LastName.Count();
            if ((length1 + lenght2) >= (length3 + length4))
                return true;
            else
                return false;
        }
        public static bool LessThanOrEqual(this Person human, Person x)
        {
            int length1, lenght2, length3, length4;
            length1 = human.FirstName.Count();
            lenght2 = human.LastName.Count();
            length3 = x.FirstName.Count();
            length4 = x.LastName.Count();
            if ((length1 + lenght2) <= (length3 + length4))
                return true;
            else
                return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Lionell", "Brown");
            Person you = new Person("Mark", "Li");
           
           bool question= me.GreaterThan(you);
           Console.WriteLine("Are you even working?");
           Console.ReadKey();
            // 1. Build out the extension methods for:
            //  GreaterThan
            //  LessThan
            //  GreaterThanOrEqual
            //  LessThanOrEqual
            // Test those methods on the Person class below.

            // 2. Take the enum for status, build an 
            // extension method that converts the status to a colored foreground
            // and background brush that you would use for a log message with that 
            // status.  Use System.ConsoleColor for the color values.

            // 3. If you have time, write an extension method on status that will
            // write a log message in the proper color.

        }
    }

    public enum Status
    {
        Critical,
        Error,
        Warning,
        Information,
        Verbose
    }

    public class Person : IComparable<Person>
    {
        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        #region IComparable<Person> Members

        public int CompareTo(Person other)
        {
            int lastCompare = LastName.CompareTo(other.LastName);
            return (lastCompare != 0) ? lastCompare :
                FirstName.CompareTo(other.FirstName);
        }

        #endregion
    }

}
