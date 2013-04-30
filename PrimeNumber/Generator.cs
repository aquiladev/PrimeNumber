using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public static class Generator
    {
        public static IList<string> Primes()
        {
            int e = 0;
            var primes = new List<string>();
            for (int i = 2; i < 1000; i++)
            {
                if (IsPrime(i))
                    primes.Add(Convert.ToString(i, CultureInfo.CurrentCulture));
            }
            return primes;
        }

        private static bool IsPrime(int n)
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
