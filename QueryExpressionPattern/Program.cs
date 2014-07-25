using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryExpressionPattern
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

    class Program
    {

        private static string[] departments = 
        {
            "rabbits",
            "birds",
            "hunters"
        };

        private static Employee[] employees = 
        {
            new Employee{FirstName="Bugs", LastName="Bunny", Age=45, Department="rabbits"},
            new Employee{FirstName="Porky", LastName="Pig", Age=38, Department="hunters"},
            new Employee{FirstName="Daffy", LastName="Duck", Age=57, Department="birds"},
            new Employee{FirstName="Tweety", LastName="Bird", Age=12, Department="birds"},
            new Employee{FirstName="Sylverster", LastName="Cat", Age=6, Department="hunters"},
            new Employee{FirstName="Elmer", LastName="Fudd", Age=64, Department="hunters"},
            new Employee{FirstName="Road", LastName="Runner", Age=19, Department="birds"},
            new Employee{FirstName="Wile", LastName="Coyote", Age=27, Department="hunters"}
        };
        static void Main(string[] args)
        {
            // Convert each of the following Fluent Syntax methods into queries:
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var smallNumbers = numbers.Where((n) => n < 5);

            IEnumerable<int> lessThanFive = from number in numbers
                                            where number > 5
                                            select number;

            var allNumbers = numbers.Select(n => n);

            IEnumerable<int> everyNumber = from number in numbers
                                           where number > -1
                                           select number;

            var squares = numbers.Select(n => new { Number = n, Square = n * n });

            IEnumerable<int> squareNumbers = from number in numbers
                                             let squared = number * number
                                             select squared;

            var people = employees.Where(e => e.Age > 30).
                OrderBy(e => e.LastName).
                ThenBy(e => e.FirstName).
                ThenBy(e => e.Age);

            IEnumerable<object> peoples = from person in employees
                                          where person.Age > 30
                                          orderby person.LastName
                                          orderby person.FirstName
                                          orderby person.Age
                                          select person;

            var results = employees.GroupBy(e => e.Department).
                Select(d => new { Department = d.Key, Size = d.Count() });

            IEnumerable<object> findings = from person in employees
                                           orderby person.Department
                                           select new Employee { Department = person.Department };
            
            var results2 = employees.GroupBy(e => e.Department).
                Select(d => new
                {
                    Department = d.Key,
                    Employees = d.AsEnumerable()
                });

            IEnumerable<object> findings2 = from person in employees
                                            orderby person.Department
                                            select new Employee { Department = person.Department };

            int[] odds = {1,3,5,7};
            int[] evens = {2,4,6,8};
            var values = odds.SelectMany(oddNumber => evens,
                (oddNumber, evenNumber) =>
                new { oddNumber, evenNumber, Sum = oddNumber + evenNumber });

            IEnumerable<int> both = from number in evens
                                    select number;
            both = from number in odds
                   select number;
            for (int i = 0; i < odds.Length; i++)
            {
                int sum = evens[i] + odds[i];
                both = both.Concat(new[] { sum });
            }

            var values2 = odds.SelectMany(oddNumber => evens,
                (oddNumber, evenNumber) =>
                new { oddNumber, evenNumber })
                .Where(pair => pair.oddNumber > pair.evenNumber).
                Select(pair => new
                {
                    pair.oddNumber,
                    pair.evenNumber,
                    Sum = pair.oddNumber + pair.evenNumber
                });

            IEnumerable<int> both2 = from number in both
                                     select number;

                                     

            var nums = new int[] { 1, 2, 3 };
            var words = new string[] { "one", "two", "three" };
            var romanNumerals = new string[] { "I", "II", "III" };
            var triples = nums.SelectMany(n => words,
                (n, s) => new { n, s }).
                SelectMany(pair => romanNumerals,
                (pair, n) => new { Arabic = pair.n, Word = pair.s, Roman = n });

            var digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var labels = new string[] { "0", "1", "2", "3", "4", "5" };
            var query = digits.Join(labels, num => num.ToString(), label => label,
                (num, label) => new { num, label });

            var groups = departments.GroupJoin(employees,
                p => p, e => e.Department, (p, emps) =>
                    new { Department = p, Employees = emps});


        }
    }
}
