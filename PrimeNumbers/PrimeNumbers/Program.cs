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
            var matrix = new int[mLength, mLength];
			var primeNumbersList = new List<int>();
            var dataProccesor = new DataProccesor(matrix, primeNumbersList, mLength);

            dataProccesor.GetPrimeNumbers();
            dataProccesor.FillMatrix();

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
