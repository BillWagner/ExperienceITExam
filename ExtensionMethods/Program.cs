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
            Person person1 = new Person("Barak", "Obama");
            Person person2 = new Person("Barak", "Obama");
            if (person1.GreaterThan(person2))
            {
                Console.WriteLine("Boo ya");
            }

            //Hehe works fine.
            Status status1 = new Status();
            Status status2 = new Status();
            Console.WriteLine(status1.CompareTo(status2));
            person1.status = Status.Critical;
            person2.status = Status.Information;

            string[] colors = person1.ConvertStatus();

            string bg = colors[0];
            string brush = colors[1];

            //System.ConsoleColor.Blue;

          

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
        public Status status = new Status();
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
        public bool GreaterThan(Person obj)
        {
            if (this.FirstName.CompareTo(obj.FirstName) > 0)
                return true;
            else return false;

        }

        public bool LessThan(Person obj)
        {
            if (this.FirstName.CompareTo(obj.FirstName) < 0)
                return true;
            else return false;
        }

        public bool GreaterThanOrEqual(Person obj)
        {
            if (this.FirstName.CompareTo(obj.FirstName) >= 0)
                return true;
            else return false;

        }

        public bool LessThanOrEqual(Person obj)
        {
            if (this.FirstName.CompareTo(obj.FirstName) <= 0)
                return true;
            else return false;

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string[] ConvertStatus()
        {
            string[] result = new string[2];
            //0 - for background, 1 fro brush
            if (this.status == Status.Critical)
            {
                result[0] = "white";
                result[1] = "green";
            }
            else if (this.status == Status.Information)
            {
                result[0] = "yellow";
                result[1] = "blue";
            }
            else {
                result[0] = "black";
                result[1] = "white";
            }
            return result;

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
