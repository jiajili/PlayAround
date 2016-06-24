using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_204
    {
        public int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;

            // init an array to track prime numbers
            bool[] primes = new bool[n];
            for (int i = 2; i < n; i++)
                primes[i] = true;

            for (int i = 2; i <= Math.Sqrt(n - 1); i++)
            {
                // or for (int i = 2; i <= n-1; i++) {
                if (primes[i])
                {
                    for (int j = i + i; j < n; j += i)
                        primes[j] = false;
                }
            }

            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (primes[i])
                    count++;
            }

            return count;
        }
    }
}
