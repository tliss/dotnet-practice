using System;
using static System.Console;
using System.Collections.Generic;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        public String FindFactors(int n)
        {
            List<int> PrimeList = new List<int>();
            string factors = "";

            while (n % 2 == 0)
            {
                PrimeList.Add(2);
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    PrimeList.Add(i);
                    n /= i;
                }
            }

            if (n > 2)
            {
                PrimeList.Add(n);
            }

            foreach(int factor in PrimeList)
            {
                factors += (factor + " x ");
            }

            return factors;
        }
    }
}
