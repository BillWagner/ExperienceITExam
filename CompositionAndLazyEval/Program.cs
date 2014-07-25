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
            var generator = new Random();
            var sequence = Enumerable.Range(0, 100)
                .Select((_) => generator.Next(int.MaxValue));
            // hint:
            int[] numbers = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = generator.Next(1, 100);
            }
            int[] evenNumbers = new int[50];
            for (int i = 0; i < 100; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenNumbers[i] = numbers[i];
            }
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
			{
			    var allFactors = Primes.PrimeFactors(numbers[i]);
                foreach (var factor in allFactors)
                {
                    Console.WriteLine(factor.Log("Adding Factor"));
                    list.Add(i);
                    list.Add(factor);
                }
			}            

            int number = 1234567890;
            var factors = Primes.PrimeFactors(number);
            foreach (var factor in factors.Log("writing factors"))
                Console.WriteLine(factor.Log("writing factor"));

            }
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

