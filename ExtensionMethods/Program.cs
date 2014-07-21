using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Build out the extension methods for: ???? Is what greater or less than? firstname/lastname? (the only 2 properties.)
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
            var person = new Person("Bob", "Dole");

            Console.WriteLine(GreaterThan(person));
            Console.WriteLine(LessThan(person));
            Console.WriteLine(GreaterThanOrEqual(person));
            Console.WriteLine(LessThanOrEqual(person));

            
            
        }

        public static bool GreaterThan(Person a)
        {
            return a.FirstName.Length > a.LastName.Length == true;
        }

        public static bool LessThan(Person a)
        {
            return a.FirstName.Length < a.LastName.Length == true;
        }

        public static bool GreaterThanOrEqual(Person a)
        {
            return a.FirstName.Length >= a.LastName.Length == true;
        }
        public static bool LessThanOrEqual(Person a)
        {
            return a.FirstName.Length <= a.LastName.Length == true;
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
