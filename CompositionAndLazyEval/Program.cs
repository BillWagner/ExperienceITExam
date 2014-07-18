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
           
            public static void Generate 100 Random Int<T>(this T obj, Action<T> action) where T : IDisposable
{
       using (obj)
       {
                action(obj);
           for(x = 0; x < 100; x++){
               myvar = rnd.(100);
           generate100[] = push.generate100[x];
               console.writeline(generate100[x]);
           }
           
       }
}  

        public static PrimeFactors Use<T>(this T obj, Action<T> action) where T : IDisposable
{
       using (obj)
       {
                action(obj);
           Console.WriteLine("Calculate primes");
      int myreadline = Console.ReadLine();
           bool isprime = false;
           string myprimearray[];


           for(int x = 0; x < myreadline; x++)
           {
               //recursion here
               // if n = n and no other divisors is prime
               // save n to array
               // test next n
               // repeat last instructions until numerics exhausted

               if(isprime == true){

               }

           }
       
       }
}  
            

        public static void OnlyEven<T>(this T obj, Action<T> action) where T : IDisposable
{
       using (obj)
       {
           int mynum;
           Console.ReadLine = mynum;
           int myeven;
           bool iseven;
           iseven = false;


           for(int x; x < mynum; x++)
           {
               myeven = myeven % x;
               if(myeven == 0){
                   iseven = true;
               }
               
              if(iseven == true){
                  Console.WriteLine(x);
                  iseven = false;
              }
           }


                action(obj);
       }
}  
            public static StructureBuilder Use<T>(this T obj, Action<T> action) where T : IDisposable
{
       using (obj)
       {


           // new up object
           // iterate with foreach
           // foreach until all objects exhausted


                action(obj);
       }
}  
            var generator = new Random();
            var sequence = Enumerable.Range(0, 100)
                .Select((_) => generator.Next(int.MaxValue));
            // hint:

            int number = 1234567890;
            var factors = Primes.PrimeFactors(number);
            foreach (var factor in factors.Log("writing factors"))
                Console.WriteLine(factor.Log("writing factor")); 
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
