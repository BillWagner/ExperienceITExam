using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        public static void Main(string[] args)
        { }
        public static int ObjectCompare(Person person)
        {
            int value = String.Compare(person.FirstName, person.LastName);
            return value;
        }

        public static int ObjectCompareGreaterOrEqual(Person person)
        {
            int value = String.Compare(person.FirstName, person.LastName);
            if (value >= 0)
                return 1;
            else
                return value;
        }

        public static int ObjetCompareLessOrEqual(Person person)
        {
            int value = String.Compare(person.FirstName, person.LastName);
            if (value <= 0)
                return -1;
            else
                return 1;
        }
        public enum Colors
        {
            Blue = 0,
            Cyan = 1,
            Green = 2,
            Red = 3,
            Yellow = 4
        };
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        ConsoleColor currentForeGround = Console.ForegroundColor;
        ConsoleColor currentBackGround = Console.BackgroundColor;


    }

    // 2. Take the enum for status, build an 
    // extension method that converts the status to a colored foreground
    // and background brush that you would use for a log message with that 
    // status.  Use System.ConsoleColor for the color values.

    // 3. If you have time, write an extension method on status that will
    // write a log message in the proper color.




    public enum Status
    {
        Critical,
        Error,
        Warning,
        Information,
        Verbose
    }



    public class Person
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
    }
}


