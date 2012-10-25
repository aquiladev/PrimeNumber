using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public static class Generator
    {
        public static IList<string> GetPrimes()
        {
            var primes = new List<string>();
            for (int i = 2; i < 1000; i++)
            {
                if (Simple(i))
                    primes.Add(Convert.ToString(i));
            }

            return primes;
        }

        private static bool Simple(int n)
        {
            int i, sq;
            if (n % 2 == 0 && n != 2) { return false; }
            sq = (int)Math.Sqrt(n);
            for (i = 3; i <= sq; i++)
            {
                if ((n % i) == 0) { return false; }
            }
            return true;
        }
    }
}
