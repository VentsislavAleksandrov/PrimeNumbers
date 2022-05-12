using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
			var mLength = n + 1;
            int p;
            int k;
			var counter = 1;
            var matrix = new int[mLength, mLength];
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
                if (counter == mLength)
                {
					break;
                }
			}

            for (int i = 1; i <= n; i++)
            {
				matrix[0, i] = primeNumbersList[i];
				matrix[i, 0] = primeNumbersList[i];
            }

            for (int i = 1; i < mLength; i++)
            {
                for (int j = 1; j < mLength; j++)
                {
					matrix[i, j] = matrix[0, j] * matrix[i, 0];
                }
            }

            for (int i = 0; i < mLength; i++)
            {
                for (int j = 0; j < mLength; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
					
                }

				Console.WriteLine();
            }
		}
    }
}
