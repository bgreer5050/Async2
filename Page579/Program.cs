using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page579
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePrimeCount();
            Console.WriteLine("Some Stuff");
            Console.ReadLine();
            
        }

        public static async void CalculatePrimeCount()
        {
            ComputeAndCountPrimeNumbers.PrimeCalc primeCount = new ComputeAndCountPrimeNumbers.PrimeCalc();
            int result = await primeCount.GetPrimesCountAsync(1, 5000000);

            Console.WriteLine("kshdbhbdsv");
            Console.WriteLine(result);
        }


    }
}
