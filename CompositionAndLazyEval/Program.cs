using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositionAndLazyEval
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a query that:
            // 1. Generates 100 random integers.
            // 2. Uses only the even numbers.
            // 3. finds all the prime factors of each number
            // 4. builds a structure for each number that contains 
            // the number, and a list of all the prime factors
            var generator = new Random();
           var randomSeq = Enumerable.Repeat(0, 100).Select(i => generator.Next(0,100));

           foreach (var x in randomSeq)
           {
               if (x % 2 == 0)
               {

               }
           }
           Console.Read();
            
            int number = 1234567890;
            var factors = Primes.PrimeFactors(number);
            foreach (var factor in factors.Log("writing factors"))
                Console.WriteLine(factor.Log("writing factor")); 
        
        
        //var query = from 
        
        }


    }

    public static class Extensions
    {
        public static T Log<T>(this T inputOutput, string message)
        {
            Console.WriteLine("Processing: {0}\tMessage:{1}", inputOutput, message);
            return inputOutput;
        }
    }

    public static class Primes
    {
        public static IEnumerable<int> PrimeFactors(int number)
        {
            return MorePrimeFactors(number, 2);
        }
        private static IEnumerable<int> MorePrimeFactors(int number, int currentFactor)
        {
            while (number % currentFactor != 0)
            {
                currentFactor++;
            }
            yield return currentFactor;
            // next bigger factor:
            if (number > currentFactor)
                foreach (int factors in MorePrimeFactors(number / currentFactor, currentFactor))
                    yield return factors;

        }

    }
}
