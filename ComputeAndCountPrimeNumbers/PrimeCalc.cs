using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAndCountPrimeNumbers
{
    public class PrimeCalc
    {
       public Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() =>
            ParallelEnumerable.Range(start, count).Count(n =>
             Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));


            
        }
    }
}
