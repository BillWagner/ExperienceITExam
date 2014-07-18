using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ExtensionMethods
{
    public static class PersonExt
    {
        public static bool GreaterThan(this Person p, Person o)
        {
            return (p.CompareTo(o) > 0);
        }

        public static bool GreaterThanOrEqual(this Person p, Person o)
        {
            return (p.CompareTo(o) >= 0);
        }

        public static bool LessThan(this Person p, Person o)
        {
            return (p.CompareTo(o) < 0);
        }

        public static bool LessThanOrEqual(this Person p, Person o)
        {
            return (p.CompareTo(o) <= 0);
        }
    }

    public static class StatusExt
    {
        public static ConsoleBrush GetConsoleBrush(this Status s)
        {
            var ret = new ConsoleBrush();
            switch (s)
            {
                case Status.Critical:
                    ret.ForegroundColor = ConsoleColor.White;
                    ret.BackGroundColor = ConsoleColor.DarkRed;
                    break;

                case Status.Error:
                    ret.ForegroundColor = ConsoleColor.Red;
                    ret.BackGroundColor = ConsoleColor.Black;
                    break;

                case Status.Information:
                    ret.ForegroundColor = ConsoleColor.White;
                    ret.BackGroundColor = ConsoleColor.Black;
                    break;

                case Status.Verbose:
                    ret.ForegroundColor = ConsoleColor.Gray;
                    ret.BackGroundColor = ConsoleColor.Black;
                    break;

                case Status.Warning:
                    ret.ForegroundColor = ConsoleColor.Yellow;
                    ret.BackGroundColor = ConsoleColor.Black;
                    break;
            }

            return ret;
        }

        public static void WriteToConsole(this Status s, string text)
        {
            var buffer = ConsoleBrush.GetCurrentConsoleBrush();
            s.GetConsoleBrush().ApplyToConsole();
            Console.WriteLine(text);
            buffer.ApplyToConsole();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Build out the extension methods for:
            //  GreaterThan
            //  LessThan
            //  GreaterThanOrEqual
            //  LessThanOrEqual
            // Test those methods on the Person class below.

            Person Jon = new Person("Jon", "Jon");
            Person Mikey = new Person("Mikey", "Mikey");

            Console.WriteLine(Jon.GreaterThan(Mikey));
            Console.WriteLine(Jon.GreaterThanOrEqual(Mikey));
            Console.WriteLine(Jon.LessThan(Mikey));
            Console.WriteLine(Jon.LessThanOrEqual(Mikey));

            Console.WriteLine();
            Console.WriteLine();

            // 2. Take the enum for status, build an 
            // extension method that converts the status to a colored foreground
            // and background brush that you would use for a log message with that 
            // status.  Use System.ConsoleColor for the color values.

            var status = Status.Critical;
            status.WriteToConsole("Oh no! We're going critical.");
            var brush = status.GetConsoleBrush();
            Console.WriteLine("{0} {1}",brush.BackGroundColor, brush.ForegroundColor);

            Console.WriteLine();
            Console.WriteLine();

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

    public class ConsoleBrush
    {
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackGroundColor { get; set; }

        public ConsoleBrush()
        {
        }

        public ConsoleBrush(ConsoleColor f, ConsoleColor b)
        {
            ForegroundColor = f;
            BackGroundColor = b;
        }

        public void ApplyToConsole()
        {
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackGroundColor;
        }

        public static ConsoleBrush GetCurrentConsoleBrush()
        {
            return new ConsoleBrush(Console.ForegroundColor, Console.BackgroundColor);
        }
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
