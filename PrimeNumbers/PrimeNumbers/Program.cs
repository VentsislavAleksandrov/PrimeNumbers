using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int p;
            int k;
			var counter = 1;
            var matrix = new int[n + 1, n + 1];
			var primeNumbersList = new List<int>();
			primeNumbersList.Add(0);

			for (int i = 2; i <= Math.Sqrt(int.MaxValue); i++)
			{
				k = 2;
				p = 1;
				while (k < i)
				{
					if (i % k == 0)
					{
						p = 0;
						break;
					}
					k++;
				}
				if (p == 1)
				{
					primeNumbersList.Add(i);
					counter++;
				}
                if (counter == n + 1)
                {
					break;
                }
			}

            for (int i = 1; i <= n; i++)
            {
				matrix[0, i] = primeNumbersList[i];
				matrix[i, 0] = primeNumbersList[i];
            }
			;
		}
    }
}
