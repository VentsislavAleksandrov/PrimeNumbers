using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = 0;
            var k = 0;
			var counter = 0;
            var matrix = new int[n, n];
			var primeNumbersList = new List<int>();

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
                if (counter == n)
                {
					break;
                }
			}

            for (int i = 0; i < primeNumbersList.Count; i++)
            {
				Console.WriteLine(primeNumbersList[i]);
            }
		}
    }
}
